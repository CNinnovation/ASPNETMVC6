using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebAPISample.Models;
using MyWebAPISample.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebAPISample.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly IBooksService _booksService;
        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        // GET: api/values
        [HttpGet]
        public Task<IEnumerable<Book>> Get() => _booksService.GetAllBooks();


        // GET api/values/5
        [HttpGet("{id}")]
        public Task<Book> Get(int id) => _booksService.FindBookById(id);


        // POST api/values
        [HttpPost]
        public Task Post([FromBody]Book value) => _booksService.AddBook(value);


        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]Book value)
        {
            if (value.BookId != id) return BadRequest();

            Book result = await _booksService.UpdateBook(value);

            return new NoContentResult();
        }


    }
}
