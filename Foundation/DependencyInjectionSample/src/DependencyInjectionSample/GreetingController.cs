using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample
{
    public class GreetingController
    {
        private readonly IHelloService _helloService;

        // dependency injection via contructor
        public GreetingController(IHelloService helloService)
        {
            _helloService = helloService;
        }

        public string MyWebGreetings(string name) =>
            $"<h1>{_helloService.Hello(name)}</h1>";
    }
}
