﻿using System.Web;
using System.Web.Mvc;

namespace _05_AreaAndFilters
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}