using Microsoft.AspNetCore.Mvc;

namespace class_work.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }
    }
}
