using MyWebAPISample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPISample.Services
{
    public class BooksService : IBooksService
    {
        private readonly List<Book> _books;

        public BooksService()
        {
            _books = new List<Book>()
            {
                new Book { BookId = 4, Publisher = "Wrox Press", Title = "Professional C# 6" },
                new Book { BookId = 7, Publisher = "AWL", Title = "Enterprise Services" },
                new Book { BookId = 9, Publisher = "Wrox Press", Title = "Beginning Visual C#" }
            };
        }

        public Task AddBook(Book book)
        {
            _books.Add(book);
            return Task.FromResult<object>(null);
        }

        public Task<Book> FindBookById(int id) =>
            Task.FromResult(_books.Find(b => b.BookId == id));

        public Task<IEnumerable<Book>> GetAllBooks() =>
            Task.FromResult<IEnumerable<Book>>(_books);

        public Task<Book> UpdateBook(Book book)
        {
            int index = _books.FindIndex(b => b.BookId == book.BookId);
            _books[index] = book;
            return Task.FromResult<Book>(book);
        }


    }
}
