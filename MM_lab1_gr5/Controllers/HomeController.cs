using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.AspNetCore.Mvc;
namespace HomeController.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() {
            ViewBag.Title = "Home";
            return View();
        }
    }
}