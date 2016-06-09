using ODataClient.BooksService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("client - wait for service");
            Console.ReadLine();
            Run();
            Console.ReadLine();
        }

        private static void Run()
        {
            Container myservice = new Container(new Uri("http://localhost:25402/odata/"));

            var q = from b in myservice.Books
                    where b.Title.StartsWith("Pro")
                    select b;

            foreach (var b in q)
            {
                Console.WriteLine(b.Title);
            }
        }
    }
}
