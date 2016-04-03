using System.Web.Mvc;
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

        [Route("{macAddress:string}")]
        public ActionResult Index(string macAddress)
        {
            var image = _HomeService.getImage(macAddress);

            return View(image);
        }
    }
}