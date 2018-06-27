using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstMVCApp.Models;

namespace MyFirstMVCApp.Services
{
    public class BooksSampleService : IBooksService
    {
        private readonly List<Book> _books;
        public BooksSampleService()
        {
            _books = new List<Book>()
            {
                new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press"},
               new Book { BookId = 2, Title = "Professional C# 7", Publisher = "Wrox Press"},

            };
        }
        public IEnumerable<Book> GetAllBooks() => _books;
    }
}
