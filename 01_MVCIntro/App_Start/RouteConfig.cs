using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _01_MVCIntro
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.MapMvcAttributeRoutes();  // to enbale attribute base routing



            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");  // here schema defination requests are ignored


            // first Route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
               // defaults: new { controller = "Home", action = "Welcome", id = UrlParameter.Optional }

                defaults: new { controller = "Category", action = "Index", id = UrlParameter.Optional }

                
            );


            //Second Routing
            routes.MapRoute(
               name: "Default1",
               url: "{controller}/{action}/{id}/{name}",
               defaults: new { controller = "Home", action = "Welcome", id = UrlParameter.Optional }
           );



        }
    }
}
