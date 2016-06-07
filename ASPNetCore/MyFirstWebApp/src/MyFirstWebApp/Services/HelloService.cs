using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Services
{
    public class HelloService : IHelloService
    {
        public string Hello(string name) => $"Hello, {name}";

    }
}
