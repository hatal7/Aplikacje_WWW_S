using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Mvc;

public class ArticleController : Controller
{
    public IActionResult Index2()
    {
        ViewBag.Title = "Article";
        return View();
    }

}