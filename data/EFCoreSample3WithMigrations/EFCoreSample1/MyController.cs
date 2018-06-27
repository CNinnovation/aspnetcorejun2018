using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreSample1
{
    public class MyController
    {
        private readonly BooksContext _booksContext;
        public MyController(BooksContext booksContext)
        {
            _booksContext = booksContext ?? throw new ArgumentNullException(nameof(booksContext));
        }

        public void AddABook()
        {

            _booksContext.Books.Add(new Book { Title = "Professional C# 7", Publisher = "Wrox Press" });
            int changed = _booksContext.SaveChanges();
            Console.WriteLine($"{changed} records changed");
        }
    }
}
