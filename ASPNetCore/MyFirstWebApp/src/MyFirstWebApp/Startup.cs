using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MyFirstWebApp.Services;
using Newtonsoft.Json;
using MyFirstWebApp.Controllers;
using MyFirstWebApp.Middleware;

namespace MyFirstWebApp
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHelloService, HelloService>();
            services.AddTransient<HelloController>();

            services.AddSession();
            services.AddDistributedMemoryCache();

            Container = services.BuildServiceProvider();
        }

        public IServiceProvider Container { get; set; }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            // app.UseH1Middleware(new H1MiddlewareOptions { NeverStop = false });
            app.UseSession();

            app.Map("/session", app1 =>
            {
                app1.Run(async (context) =>
                {
                    try
                    {
                        string sessionInfo = context.Session.GetString("MySession");
                        if (string.IsNullOrEmpty(sessionInfo))
                        {
                            context.Session.SetString("MySession", $"session created at {DateTime.Now:T}");
                            await context.Session.CommitAsync();
                            await context.Response.WriteAsync($"session created at {DateTime.Now:T}");
                        }
                        else
                        {
                            await context.Response.WriteAsync($"session exists with this information: {sessionInfo}");
                        }
                    }
                    catch (Exception ex)
                    {
                        await context.Response.WriteAsync(ex.ToString());
                    }
                });
            });


            app.MapWhen(context => context.Request.Path.Value.Contains("one"), app1 =>
            {
                app1.Run(async (context) =>
                {
                    await context.Response.WriteAsync("path contains 'one'");
                });
            });

            app.Map("/mycontroller", app1 =>
            {
                app1.Run(async (context) =>
                {
                    var controller = Container.GetService<HelloController>();
                    string html = controller.Greeting("Katharina");
                    await context.Response.WriteAsync(html);
                });

            });

            app.Map("/book", app1 =>
            {
                app1.Run(async (context) =>
                {
                    try
                    {
                        var book = new JsonSample().GetABook();

                        string json = JsonConvert.SerializeObject(book);
                        await context.Response.WriteAsync(json);
                    }
                    catch (Exception ex)
                    {

                    }
                });
            });

            app.Map("/Cookies", app1 =>
            {
                app1.Run(async (context) =>
                {
                    context.Response.Cookies.Append("Mycookie", "mycookieVal", new CookieOptions { Expires = DateTime.Now.AddDays(3) });
                    await context.Response.WriteAsync(HtmlEncoder.Default.Encode("cookie written"));
                });

            });

            app.Map("/FormSample", app1 =>
            {
                app1.Run(async (context) =>
                {
                    if (context.Request.Method == "POST")
                    {
                        string val1 = context.Request.Form["text1"];
                        await context.Response.WriteAsync($"received from the user: {HtmlEncoder.Default.Encode(val1)}");
                        return;
                    }
                    await MyForm.ReturnFormAsync(context);

                });

            });

            app.Map("/Sample2", app1 =>
            {
                app1.Run(async (context) =>
                {
                    string valx = context.Request.Query["x"].FirstOrDefault();
                    await context.Response.WriteAsync(HtmlEncoder.Default.Encode(valx));
                });

            });

            app.Map("/Sample1", app1 =>
            {
                app1.Run(async (context) =>
                {
                    await context.Response.WriteAsync("<h2>Mapped to Sample1</h2>");
                });
            });


            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<h2>Hello World!</h2>");
            });
        }
    }
}
