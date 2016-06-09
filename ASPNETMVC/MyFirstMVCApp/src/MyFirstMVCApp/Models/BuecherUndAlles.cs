using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.Models
{
    public class BuecherUndAlles
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Zeitschrift> Zeitschriften { get; set; }
    }
}
