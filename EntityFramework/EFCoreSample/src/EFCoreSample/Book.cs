using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreSample
{
    public class Book
    {
        public int BookId { get; set; }

        [MaxLength(80)]
        public string Title { get; set; }
        public string Publisher { get; set; }

        public string MainAuthor { get; set; }
    }
}
