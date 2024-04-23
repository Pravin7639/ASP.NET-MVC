using _04_MVC_CRUD_UsingDbFirstApproch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_MVC_CRUD_UsingDbFirstApproch.Controllers
{
    public class AccountController : Controller
    {

        ProductDbContext _db = new ProductDbContext();

        // GET: Account

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Users.Add(user);
                    _db.SaveChanges();

                    ViewBag.Msg = "User Created Successfully. Log In To Use Website.";

                }
                else
                {
                    ViewBag.Msg = "Please Correct Input";

                }

            }
            catch
            {
                ViewBag.Msg = "Error In Creating User";
            }


            return View();
        }
    }
}