using Microsoft.AspNetCore.Mvc;
namespace AS_lab1_gr1
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }
    }
}


