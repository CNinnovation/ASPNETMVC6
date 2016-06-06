using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SetupConfiguration(args);
            ReadConfiguration();
        }

        private static void ReadConfiguration()
        {
            string value1 = Config["mysetting1"];
            Console.WriteLine($"read config for mysetting1: {value1}");
            string value2 = Config["a"];
            Console.WriteLine($"read config for a: {value2}");
            string connectionString = Config["ConnectionStrings:DefaultConnection"];
            Console.WriteLine($"read config for connection string: {connectionString}");
            IConfigurationSection section = Config.GetSection("ConnectionStrings");

            string asecret = Config["mysecret"];
            Console.WriteLine($"read this secret from user secrets: {asecret}");
        }

        private static void SetupConfiguration(string[] args)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(@"C:\Workshop\sources\Foundation\ConfigurationSample\src\ConfigurationSample\")
                .AddJsonFile("mymandatorysettings.json")
                .AddJsonFile("myoptionalsettings.json", optional: true)
                .AddCommandLine(args)
                .AddEnvironmentVariables();

            builder.AddUserSecrets();

#if DEVELOP

#endif
            Config = builder.Build();
        }

        public static IConfigurationRoot Config { get; private set; }
    }
}
