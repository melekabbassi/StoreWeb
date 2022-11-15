using Microsoft.AspNetCore.Mvc;

namespace StoreWeb.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public String Index()
        //{
        //    return "Products List";
        //}

        //public String NutritionList()
        //{
        //    return "Nutrition List";
        //}
    }
}
