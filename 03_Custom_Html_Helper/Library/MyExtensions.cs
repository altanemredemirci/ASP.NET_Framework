using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_Custom_Html_Helper.Library
{
    public static class MyExtensions
    {
        public static MvcHtmlString Button(this HtmlHelper helper, string id,string typ,string text)
        {
            string html = string.Format("<button id='{0}' name='{0}' type='{1}'>{2}</button>", id, typ, text);

            return MvcHtmlString.Create(html);
        }

    }
}