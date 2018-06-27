using MyFirstMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.Services
{
    public interface IBooksService
    {
        IEnumerable<Book> GetAllBooks();
    }
}
