using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Repositories;
using System.Web.UI.WebControls;

namespace Capstone.Services
{
    public class HomeService
    {
        private readonly HomeRepository _HomeRepository;

        public HomeService()
        {
            _HomeRepository = new HomeRepository();
        }

        public ImageMap getImage(string macAddress)
        {
            var image = new ImageMap();

            // TODO: Get the image data and put into object.

            return image;
        }
    }
}