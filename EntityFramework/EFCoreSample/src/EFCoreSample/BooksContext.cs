using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSample
{
    public class BooksContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=BooksSample;trusted_connection=true");
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().ToTable("Buecher");
            modelBuilder.Entity<Book>().Property(b => b.Publisher).HasMaxLength(20);
        }
    }
}
