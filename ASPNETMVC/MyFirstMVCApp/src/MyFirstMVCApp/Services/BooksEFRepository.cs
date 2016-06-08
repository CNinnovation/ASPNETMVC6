using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstMVCApp.Models;

namespace MyFirstMVCApp.Services
{
    public class BooksEFRepository : IBooksRepository2, IDisposable
    {
        private readonly BooksContext _data;
        public BooksEFRepository(BooksContext data)
        {
            _data = data;

            _data.Database.EnsureCreated();
        }

        public async Task AddBookAsync(Book book)
        {
            _data.Books.Add(book);
            await _data.SaveChangesAsync();
        }

        public void Dispose()
        {
            _data.Dispose();
        }

        public Task<IEnumerable<Book>> GetBooksAsync()
        {
           
            return null;
            //_data.Books.
            //IAsyncEnumerable<Book> books = _data.Books.ToAsyncEnumerable();
        }
    }
}
