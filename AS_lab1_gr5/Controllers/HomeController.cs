using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AS_lab1_g5.Controllers;

public class HomeController:Controller
{
    public IActionResult Index()
    {
        ViewBag.Title="Home";
        return View();
    }
}

