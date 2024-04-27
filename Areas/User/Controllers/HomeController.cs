using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_AreaAndFilters.Areas.User.Controllers
{
    [RouteArea("User")] // // confusion occured because we have multiple home controller

    public class HomeController : Controller
    {
       
        // GET: User/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}