using Microsoft.AspNetCore.Mvc;
namespace AS_lab1_gr6.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        ViewBag.Title = "Home";
        return View();
    }

}

