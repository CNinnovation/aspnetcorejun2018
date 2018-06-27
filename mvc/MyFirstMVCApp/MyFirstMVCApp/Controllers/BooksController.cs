using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApp.Models;
using MyFirstMVCApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.Controllers
{
    public class BooksController : Controller
    {
        private IBooksService _booksService;
        public BooksController(IBooksService booksService)
        {
            _booksService = booksService ?? throw new ArgumentNullException(nameof(booksService));
        }
        public IActionResult Index()
        {
            return Json(_booksService.GetAllBooks());
        }

        public IActionResult ShowBook(int id)
        {
            Book book = _booksService.GetAllBooks().SingleOrDefault(b => b.BookId == id);
            return View(book);
        }

        public IActionResult MyView()
        {
            ViewData["mydata"] = "data coming from the controller";
            ViewBag.MoreData = "more data from the controller";
            return View();
        }

        public IActionResult AnotherView()
        {
            ViewData["mydata"] = "data coming from the controller for another view";
            ViewBag.MoreData = "more data from the controller";
            return View("MyView");
        }

        public IActionResult ShowBooks1()
        {
            var books = _booksService.GetAllBooks();
            ViewBag.Books = books;
            return View();
        }

        public IActionResult ShowBooks2()
        {
            var books = _booksService.GetAllBooks();
            return View(books);
        }

        public IActionResult ShowBooks3()
        {
            var books = _booksService.GetAllBooks();
            return View(books);
        }

        public IActionResult UseMyLayout() => View();

        public IActionResult UseMyPartialView2() => View();
        public IActionResult MyPartialView2() => PartialView();

        public IActionResult UseMyViewComponent1() => View();

        public IActionResult UseMyViewComponent2() => View();
    }
}
