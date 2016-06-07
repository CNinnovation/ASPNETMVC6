using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyFirstWebApp.Services
{
    public class MyForm
    {
        public static async Task ReturnFormAsync(HttpContext context)
        {
            string htmlContent = "<form method='post' action='FormSample/SubmitData'>" +
                "<input type='text' id='text1' name='text1' />" +
                "<br />" +
                "<button type='submit'>Submit</button>" +
                "</form>";
            await context.Response.WriteAsync(htmlContent);
        }
    }
}
