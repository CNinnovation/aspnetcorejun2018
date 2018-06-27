using System;

namespace EFCoreSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleData();
        }

        private static void SampleData()
        {
            using (var context = new BooksContext())
            {
                bool created = context.Database.EnsureCreated();
                Console.WriteLine($"database created: {created}");
                context.Books.Add(new Book { Title = "Professional C# 7", Publisher = "Wrox Press" });
                int changed = context.SaveChanges();
                Console.WriteLine($"{changed} records changed");
            }
        }
    }
}
