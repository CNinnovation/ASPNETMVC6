using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InitLogging();

            Foo();

        }

        private static void Foo()
        {
            Logger.LogInformation("Foo started");
            Bar("one");

            Logger.LogInformation("Foo finished");
        }

        private static void Bar(string v)
        {
            Logger.LogError("some error in Bar");
        }

        private static void InitLogging()
        {
            var loggerFactory = new LoggerFactory().AddConsole().AddDebug();

            Logger = loggerFactory.CreateLogger<Program>();
        }

        public static ILogger Logger { get; private set; }
    }
}
