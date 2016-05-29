using System;

namespace DependencyInjection
{
    public class HelloController
    {
        private readonly IGreetingService _greetingService;
        public HelloController(IGreetingService greetingService)
        {
            if (greetingService == null) throw new ArgumentNullException(nameof(greetingService));
            _greetingService = greetingService;
        }

        public string Action(string name) =>
            _greetingService.Greeting(name);
    }
}
