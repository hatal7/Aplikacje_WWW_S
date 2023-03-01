using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller{
    public IActionResult Index(){
        ViewBag.Title="Home";
        return View();
    }
}