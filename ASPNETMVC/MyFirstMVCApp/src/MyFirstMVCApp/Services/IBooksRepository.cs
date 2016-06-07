using MyFirstMVCApp.Models;
using System.Collections.Generic;

namespace MyFirstMVCApp.Services
{
    public interface IBooksRepository
    {
        Book GetTheBook();
        IEnumerable<Book> GetBooks();
    }
}