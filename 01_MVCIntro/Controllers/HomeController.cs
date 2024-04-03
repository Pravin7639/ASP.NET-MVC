using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_MVCIntro.Controllers
{

    [RoutePrefix("")]

    public class HomeController : Controller
    {

        //// GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}


        public string Welcome()
        {
            return "My First MVC Application";
        }

        public string GetResult(int id)
        {
            return $"You have Passed {id} input values";
        }

        public string GetEmployeeData(int id, string name)
        {
            return $"Employee ID : {id} Employee Name : {name} ";
        }


        //[Route("Pravin/home/{id}/{StudentName}")]

        [Route("Pravin/{id}/{StudentName}")]


        public string GetStudentData(int id, string StudentName)
        {
            return $"Student ID : {id} Student Name : {StudentName} ";
        }


    }
}