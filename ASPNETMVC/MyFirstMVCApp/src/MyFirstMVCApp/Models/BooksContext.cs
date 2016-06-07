using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.Models
{
    public class BooksContext
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
