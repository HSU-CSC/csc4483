using Capstone.Models;
using Capstone.Models.Home;
using System.Collections.Generic;
using System.Linq;

namespace Capstone.Repositories
{
    public class HomeRepository
    {
        private readonly EfDbContext _EfDbContext;

        public HomeRepository()
        {
            _EfDbContext = new EfDbContext();
        }

        public ImageMap getImageMap(string macAddress)
        {
            var deviceId = _EfDbContext.Devices.FirstOrDefault(d => d.MacAddress == macAddress).Id;
            var imageMap = _EfDbContext.ImageMaps.FirstOrDefault(i => i.DeviceId == deviceId);

            return imageMap;
        }

        public IEnumerable<ImageMapRegion> getImageMapRegions(int imageMapId)
        {
            var regions = _EfDbContext.ImageMapRegions.Where(r => r.ImageMapId == imageMapId);

            return regions;
        }
    }
}