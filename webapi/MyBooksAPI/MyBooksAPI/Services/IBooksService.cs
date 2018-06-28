using System.Collections.Generic;
using MyBooksAPI.Models;

namespace MyBooksAPI.Services
{
    public interface IBooksService
    {
        void AddBook(Book book);
        Book GetBookById(int id);
        IEnumerable<Book> GetBooks();
    }
}