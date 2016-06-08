using MyFirstMVCApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyFirstMVCApp.Services
{
    public interface IBooksRepository
    {
        Book GetTheBook();
        IEnumerable<Book> GetBooks();
    }

    public interface IBooksRepository2
    {
        Task<IEnumerable<Book>> GetBooksAsync();
        Task AddBookAsync(Book book);
    }
}