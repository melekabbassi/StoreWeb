using Microsoft.AspNetCore.Mvc;

namespace StoreWeb.Controllers
{
    public class CarController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public string Index()
        {
            return "Car List";
        }

        public IActionResult CollectList(string brand, string year)
        {
            ViewData["brand"] = brand;
            ViewData["year"] = year;
            return View();
        }
    }
}
