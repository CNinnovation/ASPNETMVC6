using MyWebAPISample.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("client - wait for server");
            Console.ReadLine();

            // GetAll2().Wait();
            AddABook().Wait();
            GetBooks().Wait();
        }

        private static async Task AddABook()
        {
            using (var client = new HttpClient())
            {
                Book newBook = new Book { BookId = 42, Publisher = "Self", Title = "Cool Apps" };
                string jsonBook = JsonConvert.SerializeObject(newBook);
                HttpContent content = new StringContent(jsonBook, Encoding.UTF8, "application/json");
                HttpResponseMessage resp = await client.PostAsync("http://localhost:18941/api/Books", content);
                resp.EnsureSuccessStatusCode();
            }
        }

        private static async Task GetBooks()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage resp = await client.GetAsync("http://localhost:18941/api/Books");
                resp.EnsureSuccessStatusCode();

                string json = await resp.Content.ReadAsStringAsync();
                IEnumerable<Book> books = JsonConvert.DeserializeObject<IEnumerable<Book>>(json);
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }

        private static async Task GetAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage resp = await client.GetAsync("http://localhost:18941/api/values");
                resp.EnsureSuccessStatusCode();

                string json = await resp.Content.ReadAsStringAsync();
                IEnumerable<string> teams = JsonConvert.DeserializeObject<IEnumerable<string>>(json);
                foreach (var team in teams)
                {
                    Console.WriteLine(team);
                }
            }
        }

        private static async Task GetAll2()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/xml"));
                HttpResponseMessage resp = await client.GetAsync("http://localhost:18941/api/values");
                resp.EnsureSuccessStatusCode();

                string content = await resp.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
        }
    }
}
