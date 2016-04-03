using Capstone.Models;
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

        public IEnumerable<Point> getImage(string macAddress)
        {
            var deviceId = _EfDbContext.Devices.FirstOrDefault(d => d.MacAddress == macAddress);
        }
    }
}