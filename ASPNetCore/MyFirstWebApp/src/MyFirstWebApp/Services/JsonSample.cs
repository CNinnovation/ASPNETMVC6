using MyFirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Services
{
    public class JsonSample
    {


        public Book GetABook() => new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press" };

    }
}
