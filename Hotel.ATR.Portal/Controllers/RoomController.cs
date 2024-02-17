using Hotel.ATR.Portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.ATR.Portal.Controllers
{
    public class RoomController : Controller
    {
        private IWebHostEnvironment webHost;
        public RoomController(IWebHostEnvironment webHost)
        {
            this.webHost = webHost;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RoomList()
        {
            return View();
        }
        public IActionResult RoomDetails()
        {
            return View();
        }
        [HttpPost]
        ///(User user)
        ///string email,string name
        public IActionResult SubscribeNewsletter(IFormFile userfile) {
            var data = Request.Form;

            string path = Path.Combine(webHost.WebRootPath,userfile.FileName);
            
            using(var stream=new FileStream(path, FileMode.Create))
            {
                userfile.CopyTo(stream);
            }

            return View();

        }
    }
}
