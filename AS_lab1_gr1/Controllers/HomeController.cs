using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Mvc;

public class Homecontroller : Controller{
        public IActionResult Index()
{
    ViewBag.Title="Home";
    return View();
}
}
