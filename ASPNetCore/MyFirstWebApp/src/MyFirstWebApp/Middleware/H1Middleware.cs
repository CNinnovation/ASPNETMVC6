using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MyFirstWebApp.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class H1Middleware
    {
        private readonly RequestDelegate _next;

        public H1Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (!H1MiddlewareExtensions.Options.NeverStop && httpContext.Request.Path.Value.Contains("stop"))
            {
                await httpContext.Response.WriteAsync("<h1>this middleware is last!</h1>");
            }
            else
            {
                await httpContext.Response.WriteAsync("<h1>from the middleware</h1>");
                await _next(httpContext);
            }
        }
    }

    public class H1MiddlewareOptions
    {
        public bool NeverStop { get; set; }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class H1MiddlewareExtensions
    {
        public static H1MiddlewareOptions Options { get; private set; }
        public static IApplicationBuilder UseH1Middleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<H1Middleware>();
        }

        public static IApplicationBuilder UseH1Middleware(this IApplicationBuilder builder, H1MiddlewareOptions options)
        {
            Options = options;
            return builder.UseMiddleware<H1Middleware>();
        }
    }
}
