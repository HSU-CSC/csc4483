using Capstone.Repositories;
using System.Web.UI.WebControls;
using System.Linq;
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

        public System.Web.UI.WebControls.ImageMap getImageMap(string macAddress)
        {
            var image = new System.Web.UI.WebControls.ImageMap();
            var imageInfo = _HomeRepository.getImageMap(macAddress);
            var regions = _HomeRepository.getImageMapRegions(imageInfo.Id);

            foreach (var r in regions)
            {
                image.HotSpots.Add(new RectangleHotSpot { Left = r.TopLeftX, Top = r.TopLeftY, Right = r.BottomRightX, Bottom = r.BottomRightY, NavigateUrl = r.PostbackURL});
            }

            image.ImageUrl = imageInfo.ImageFile;

            return image;
        }
    }
}