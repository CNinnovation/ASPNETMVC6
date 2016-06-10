using System.Collections.Generic;
using System.Threading.Tasks;
using MyWebAPISample.Models;

namespace MyWebAPISample.Services
{
    public interface IBooksService
    {
        Task AddBook(Book book);
        Task<Book> FindBookById(int id);
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> UpdateBook(Book book);
    }
}