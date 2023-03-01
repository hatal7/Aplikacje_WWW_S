using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AS_lab1_g5.Controllers;

public class ArticleController:Controller
{
    public IActionResult Index()
    {
        ViewBag.Title="Artykul";
        return View();
    }
}