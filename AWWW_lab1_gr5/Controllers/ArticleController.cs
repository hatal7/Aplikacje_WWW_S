using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AWWW_lab1_gr5.Models;

namespace AWWW_lab1_gr5.Controllers
{
    [Route("[controller]")]
    public class ArticleController : Controller
    {
        private readonly ILogger<ArticleController> _logger;

        public ArticleController(ILogger<ArticleController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var article = new Articles
            {
             Id = 1,
             Title = "Artykuł 1",
             Content = "Lorem ipsum...",
             CreationDate = DateTime.Now
            };
            return View(article);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}