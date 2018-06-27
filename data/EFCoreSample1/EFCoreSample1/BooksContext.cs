using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreSample1
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        private string connectionString = @"server=(localdb)\mssqllocaldb;database=Books2;trusted_connection=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(b => b.Publisher).HasMaxLength(30).IsRequired();
        }
    }
}
