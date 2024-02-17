using Microsoft.AspNetCore.Mvc;

namespace Hotel.ATR.Portal.Views
{
    public class Event : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
