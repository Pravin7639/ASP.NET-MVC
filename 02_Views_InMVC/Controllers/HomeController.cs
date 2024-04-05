using _02_Views_InMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_Views_InMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            ViewData["name"] = "TATA Consultancy Services";
            ViewBag.Email = "support@tcs.com";

            TempData["address"] = "Value Stored in TempData";


            return View();
        }

        public ActionResult Index1()
        {
            return View();
        }


        public ActionResult Index3()
        {
            int num = 45;
            return View("Index3", num);
        }

        public ActionResult Index4()
        {
            Product p = new Product() { Id = 1, Name = "Shirt", Price = 499 };
            return View(p);
        }



    }
}