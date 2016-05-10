using System.Web.Mvc;
using Capstone.Models.Home;
using Capstone.Services;

namespace Capstone.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeService _HomeService;

        public HomeController()
        {
            _HomeService = new HomeService();
        }

        [Route("~/start/{macAddress}")]
        public ActionResult Index(string macAddress)
        {
            var image = _HomeService.getImageMap(macAddress);

            return View(image);
        }


       public ActionResult FeedReader(int deviceId)
        {
            Feed data = _HomeService.getFeed(deviceId);
            FeedData info = _HomeService.getFeedData(data);
           string Url = info.FeedUrl;

           ViewData.Model = Url;
           return View();
        }
    }
}