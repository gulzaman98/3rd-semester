using Microsoft.AspNetCore.Mvc;
using class_work.Models;

namespace class_work.Controllers
{
    public class SiCalcController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Si obj = new Si();
            return View(obj);
        }
        [HttpPost]
        public IActionResult Index(Si obj)
        {

            double si = (obj._p * obj._r * obj._t) / 100;
            ViewBag.Result = "Result is " + si;
            return View();

        }

        public IActionResult TestData()
        {
            return RedirectToAction("Home" , "Guest");
        }
    }
}
