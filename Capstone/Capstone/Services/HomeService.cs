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

        public Feed getFeed(int deviceId)
        {
            var data = _HomeRepository.getFeed(deviceId);

            return data;
        }

        public FeedData getFeedData(Feed data)
        {

            var info = _HomeRepository.getFeedData(data);

            return info;
        }
    }
}