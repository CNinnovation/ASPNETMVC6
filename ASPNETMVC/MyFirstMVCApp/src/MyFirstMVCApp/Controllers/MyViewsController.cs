using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApp.Services;
using MyFirstMVCApp.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstMVCApp.Controllers
{
    public class MyViewsController : Controller
    {
        private readonly IBooksRepository _booksRepository;
        public MyViewsController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AnotherView() => View("View2");

        public IActionResult PassViewData()
        {
            // ViewData["MyData"] = "hello from the controller";
            ViewBag.MyData = "data from the controller";
            return View();
        }

        public IActionResult PassAModel()
        {
            Book book = _booksRepository.GetTheBook();

            return View(book);
        }

        public IActionResult PassAModelCollection()
        {
            var books = _booksRepository.GetBooks();

            return View(books);
        }

        public IActionResult UseAPartialView()
        {
            return View();
        }
    }
}
