using Microsoft.AspNetCore.Mvc;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Tittle = "Home";
        return View();
    }

}




