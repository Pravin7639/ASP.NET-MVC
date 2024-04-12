using _03_MVC_CRUD_UsingDBFirstApproch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_MVC_CRUD_UsingDBFirstApproch.Controllers
{
    public class StudentController : Controller
    {

        StudentDbContext _db = new StudentDbContext();
        // GET: Student
        public ActionResult Index()
        {
            var students = _db.Students.ToList();

            return View(students);
        }
    

        [HttpGet]
    public ActionResult Delete(int? id)
        {
            var student = _db.Students.Find(id);
            return View(student);
        }



        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? Id)
        {
            var student = _db.Students.Find(Id);

            _db.Students.Remove(student);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }




    }
}