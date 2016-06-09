using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [StringLength(20)]
        public string Title { get; set; }

        [Editable(allowEdit:false)]
        [Display(AutoGenerateField =false)]
        
        public string Publisher { get; set; }


        [DataType(DataType.Currency)]
        [Display(Name ="Preis")]
        public decimal Price { get; set; }
    }
}
