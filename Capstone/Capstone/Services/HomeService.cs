using Capstone.Repositories;
using Capstone.Models.Home;

namespace Capstone.Services
{
    public class HomeService
    {
        private readonly HomeRepository _HomeRepository;

        public HomeService()
        {
            _HomeRepository = new HomeRepository();
        }

        public ImageMap getImageMap(string macAddress)
        {
            var image = _HomeRepository.getImageMap(macAddress);
            image.Regions = _HomeRepository.getImageMapRegions(image.Id);

            return image;
        }
    }
}