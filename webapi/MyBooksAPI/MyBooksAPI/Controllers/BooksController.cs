using Microsoft.AspNetCore.Mvc;
using MyBooksAPI.Models;
using MyBooksAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IBooksService _booksService;
        public BooksController(IBooksService booksService)
        {
            _booksService = booksService ?? throw new ArgumentNullException(nameof(booksService));
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
           return new ActionResult<IEnumerable<Book>>(_booksService.GetBooks());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]       
        public ActionResult<Book> GetBookById(int id)
        {
            return new ActionResult<Book>(_booksService.GetBookById(id));
        }

        [HttpPost]
        public void Post(Book value)
        {
            _booksService.AddBook(value);
        }
    }
}
