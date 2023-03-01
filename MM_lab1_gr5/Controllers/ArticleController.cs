using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using AS_lab1_gr1.Models;

namespace Article.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index() {
           var article = new Article {
            Id = 1,
            Title = "Artykuł 1",
            Content = "Lorem ipsum...",
            CreationDate = DateTime.Now
           };
           return View(article);
        }
    }
}