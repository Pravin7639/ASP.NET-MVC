using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_MVCIntro.Controllers
{
    public class CategoryController : Controller   // by default this page is start up page
    {
        //// GET: Category
        //public ActionResult Index()
        //{
        //    return View();
        //}


        public ViewResult Index()  // this will seach in view-->Category and Shared folder --> in this folder it will search for Index Method
        {
            //   return View();  // use this when view is in same folder

            //return View("Index1");

            return View("~/Views/Student/Index.cshtml");
        }


        //this is manually created view
        public ViewResult AllCategories()
        {
            return View();

        }


    }
}