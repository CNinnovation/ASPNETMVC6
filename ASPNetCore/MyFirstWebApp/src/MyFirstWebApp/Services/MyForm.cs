using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Services
{
    public class MyForm
    {
        public static async Task ReturnFormAsync(HttpContext context)
        {
            await context.Response.WriteAsync("<form method='post' action='FormSample/SubmitData'>");
            await context.Response.WriteAsync("<input type='text' id='text1' name='text1' />");
            await context.Response.WriteAsync("<hr />");
            await context.Response.WriteAsync("<button type='submit'>Submit</button>");
            await context.Response.WriteAsync("</form>");
        }
    }
}
