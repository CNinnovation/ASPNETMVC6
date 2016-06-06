using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjectionSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RegisterServices();

            DIWithoutAContainer();
            DIWithAContainer();
        }

        private static void DIWithAContainer()
        {
            try
            {
                var controller = Container.GetService<GreetingController>();
                string greeting = controller.MyWebGreetings("Matthias");
                Console.WriteLine(greeting);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void DIWithoutAContainer()
        {
            var controller = new GreetingController(new MyHelloService());
            string greeting = controller.MyWebGreetings("Stephanie");
            Console.WriteLine(greeting);
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            // services.AddSingleton<IHelloService, MyHelloService>();
            services.AddTransient<GreetingController>();
            Container = services.BuildServiceProvider();
        }

        public static IServiceProvider Container { get; private set; }
    }
}
