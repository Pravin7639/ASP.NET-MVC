using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_AreaAndFilters.Areas.Seller.Controllers
{
    [RouteArea("Seller")] //  // confusion occured because we have multiple home controller
    public class HomeController : Controller
    {
        // GET: Seller/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}