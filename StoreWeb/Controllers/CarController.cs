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
    }
}
