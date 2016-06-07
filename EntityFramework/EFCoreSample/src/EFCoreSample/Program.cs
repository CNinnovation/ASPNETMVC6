using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateBooks();
        }

        private static void CreateBooks()
        {
            try
            {
                using (BooksContext data = new BooksContext())
                {
                    bool created = data.Database.EnsureCreated();
                    if (created)
                    {
                        Console.WriteLine("database created...");
                    }
                    data.Books.Add(new Book { Title = "Professional C# 6", Publisher = "Wrox Press" });
                    int changed = data.SaveChanges();
                    Console.WriteLine($"changed {changed} records");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
