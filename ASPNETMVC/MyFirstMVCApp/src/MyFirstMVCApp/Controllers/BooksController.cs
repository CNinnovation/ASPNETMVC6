using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApp.Models;
using MyFirstMVCApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksRepository2 _booksRepository;
        public BooksController(IBooksRepository2 booksRepository)
        {
            _booksRepository = booksRepository;
        }
        //public IActionResult Index()
        //{
            
        //}

        public IActionResult AddBook()
        {
            return View("AddBook2");
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(Book book)
        {

            await _booksRepository.AddBookAsync(book);
            return Ok();
        }
    }
}
