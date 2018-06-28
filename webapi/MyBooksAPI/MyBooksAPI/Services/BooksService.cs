using MyBooksAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBooksAPI.Services
{
    public class BooksService : IBooksService
    {
        private List<Book> _books = new List<Book>()
        {
            new Book { BookId = 1, Title = "One", Publisher ="pub1"},
            new Book { BookId = 2, Title = "Two", Publisher ="pub1"},
            new Book { BookId = 3, Title = "Three", Publisher ="pub1"},
        };

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> GetBooks() => _books;

        public Book GetBookById(int id) => _books.SingleOrDefault(b => b.BookId == id);

        public void AddBook(Book book) => _books.Add(book);
    }
}
