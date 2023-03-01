using Microsoft.AspNetCore.Mvc;
using AS_lab1_gr1.Models;

namespace AS_lab1_gr1
{
public class AddController :Controller
{
    public IActionResult Index()
    {
        var article = new Article { 
            Id = 1, 
            Title = "Artykul 1", 
            Content = "Lorem ipsum...", 
            CreationDate = DateTime.Now 
            };
            return View(article);
    }
}

   
}
