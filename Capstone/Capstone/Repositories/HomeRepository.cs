using Capstone.Models;
using System.Linq;
using System.Web.UI.WebControls;

namespace Capstone.Repositories
{
    public class HomeRepository
    {
        private readonly EfDbContext _EfDbContext;

        public HomeRepository()
        {
            _EfDbContext = new EfDbContext();
        }

        public ImageMap getImage(string macAddress)
        {
            var deviceId = _EfDbContext.Devices.FirstOrDefault(d => d.MacAddress == macAddress);

            return null;
        }
    }
}