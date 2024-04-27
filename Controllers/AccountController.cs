using _05_AreaAndFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_AreaAndFilters.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account

        [HttpGet]

        public ActionResult Login()
        {
            return View();
        }





        [HttpPost]

        public ActionResult Login(LoginModel user)
        {

            if(user.UserName=="admin" && user.Password == "admin")
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }
            else if (user.UserName == "seller" && user.Password == "seller")
            {
                return RedirectToAction("Index", "Home", new { area = "Seller" });
            }
            else if (user.UserName == "user" && user.Password == "user")
            {
                return RedirectToAction("Index", "Home", new { area = "User" });
            }
            else
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            return View();
        }
    }
}