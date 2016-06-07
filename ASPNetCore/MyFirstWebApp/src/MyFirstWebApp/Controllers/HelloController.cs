using MyFirstWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Controllers
{
    public class HelloController
    {
        private readonly IHelloService _helloService;

        public HelloController(IHelloService helloService)
        {
            _helloService = helloService;
        }

        public string Greeting(string name) => $"<h2>{_helloService.Hello(name)}</h2>";
    }
}
