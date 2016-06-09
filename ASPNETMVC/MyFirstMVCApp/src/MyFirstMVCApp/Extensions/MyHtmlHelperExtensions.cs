using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVCApp.Extensions
{
    public static class MyHtmlHelperExtensions
    {
        public static IHtmlContent Foo<T>(this IHtmlHelper<T> helper, bool toUpper)
        {
            if (toUpper)
            {
                return new HtmlString("FOO");
            }
            else
            {
                return new HtmlString("foo");
            }
        }
    }
}
