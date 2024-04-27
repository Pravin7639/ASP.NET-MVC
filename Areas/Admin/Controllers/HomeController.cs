using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_AreaAndFilters.Areas.Admin.Controllers
{
  /*  [RouteArea("Admin")]*/  //  // confusion occured because we have multiple home controller
    public class HomeController : BaseController
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}