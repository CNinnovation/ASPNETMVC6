using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ViewsFromLibraries.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index() => View();

        public string Hello() => "Books.Hello";
    }
}
