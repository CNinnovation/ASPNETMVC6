using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EFCoreSample;

namespace EFCoreSample.Migrations
{
    [DbContext(typeof(BooksContext))]
    [Migration("20160608073854_InitBooks")]
    partial class InitBooks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreSample.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Publisher")
                        .HasAnnotation("MaxLength", 20);

                    b.Property<string>("Title")
                        .HasAnnotation("MaxLength", 80);

                    b.HasKey("BookId");

                    b.ToTable("Buecher");
                });
        }
    }
}
