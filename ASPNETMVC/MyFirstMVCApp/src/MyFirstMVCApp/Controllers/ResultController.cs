using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApp.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstMVCApp.Controllers
{
    public class ResultController : Controller
    {
        private readonly IBooksRepository _booksRepository;
        public ResultController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult RedirectSample() => Redirect("http://www.cninnovation.com");

        public IActionResult NotFoundSample() => NotFound();

        public IActionResult JsonSample() => Json(_booksRepository.GetTheBook());

    }
}
