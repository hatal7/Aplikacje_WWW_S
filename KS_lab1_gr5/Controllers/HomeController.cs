using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class Homecontroller : Controller
{
    public IActionResult Index()
    {
        ViewBag.Title = "Home";
        return View();
    }


}