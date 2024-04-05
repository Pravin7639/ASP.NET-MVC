using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_Views_InMVC.Common
{
    public static class CustomHtmlHelper
    {

        public static MvcHtmlString Button (this HtmlHelper htmlHelper, string type,string value)
        {
            TagBuilder tb = new TagBuilder("input");

            tb.Attributes.Add("type", type);
            tb.Attributes.Add("value", value);

            return new MvcHtmlString(tb.ToString());
        }

       
    }
}