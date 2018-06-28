using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApp.Models;

namespace MyFirstMVCApp.Controllers
{
    public class HtmlHelpersController : Controller
    {
        public IActionResult Index()
        {
            var b = new Book { BookId = 1, Title = "Professional C#", Publisher = "Wrox" };
            return View(b);
        }
    }
}