using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MyFirstMVCApp.Services;
using MyFirstMVCApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MyFirstMVCApp
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true);

            Configuration = builder.Build();

        }

        public IConfigurationRoot Configuration { get;  }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<BooksContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddSingleton<IBooksRepository, BooksRepository>();
            services.AddScoped<IBooksRepository2, BooksEFRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            // app.UseMvcWithDefaultRoute();

            app.UseMvc(route =>
                route.MapRoute("default",
                    "{controller}/{action}/{name?}",
                    new { controller = "Home", action = "Index" }));

            app.UseMvc(route =>
                route.MapRoute("calc",
                    "Calc/{action}/{x}/{y}",
                    new { controller = "Home"}
                    ));

            app.UseMvc(route =>
                route.MapRoute("lang",
                    "{lang}/{controller}/{action}",
                    new { lang = "en", controller = "Home", action = "Index" },
                    constraints: new { lang = @"(en)|(de)" }));

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
