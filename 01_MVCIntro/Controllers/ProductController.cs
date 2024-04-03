using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_MVCIntro.Controllers
{
    [RoutePrefix("pravin")]


    public class ProductController : Controller
    {
        //https://locslhost/pravin

      [Route("")]
        public string GetProducts()
        {
            //return "All List Of Product";

            return "<h1>All Products </h1> No Products Available";

        }

        public EmptyResult Index()   //http://localhost/product/index
        {
            return new EmptyResult();
        }

        public ContentResult Index1() //http://localhost/product/index1
        {
            return Content("Hello");
        }

        //public ActionResult Index11() //http://localhost/product/index1
        //{
        //    return Content("Hello");
        //}


        public ContentResult Index2()    //http://localhost/product/index2
        {
            return Content("<h1>Index 2 Page </h1> ", "text/html");

            //return Content("<h1>Index 2 Page </h1> ");
        }

        public RedirectResult Index3()    //http://localhost/product/index3
        {
            return Redirect("https://www.google.com");
        }

        public JsonResult Index4()
        {
            string json = "{'Id': 45, 'Name' : 'Pravin' 'City' : 'Pune' }";

            return Json(json, JsonRequestBehavior.AllowGet);
        }




    }
}