using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index() => $"{nameof(HomeController)}.{nameof(Index)}";

        public string Foo() => "Foo";

        public string Greeting(string name) => $"Hello, {name}";

        public int Add(int x, int y) => x + y;

        public int Subtract(int x, int y) => x - y;
    }
}
