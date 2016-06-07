using MyFirstMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.Services
{
    public class BooksRepository : IBooksRepository
    {
        public Book GetTheBook() => new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press" };

        public IEnumerable<Book> GetBooks() =>
            new List<Book>()
            {
                new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press" },
                new Book { BookId = 2, Title = "Enterprise Services", Publisher = "AWL" },
                new Book { BookId = 3, Title = "Programming Universal Apps", Publisher = "Self" }
            };
    }
}
