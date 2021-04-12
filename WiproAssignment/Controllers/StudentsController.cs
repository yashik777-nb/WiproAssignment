using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WiproAssignment.Models;

namespace WiproAssignment.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        [Route("Students")]
        public ActionResult Index()
        {
            var students = GetStudents();
            return View("Students", students);
        }

        private IEnumerable<Student> GetStudents()
        {
            return new List<Student> { 
                new Student { RollNo = 1, Sname = "Student One", Std = "1st"},
                new Student { RollNo = 2, Sname = "Student Two", Std = "2nd"},
                new Student { RollNo = 3, Sname = "Student Three", Std = "3rd"},
                new Student { RollNo = 4, Sname = "Student Four", Std = "4th"},
                new Student { RollNo = 5, Sname = "Student Five", Std = "5th"},
                new Student { RollNo = 6, Sname = "Student Six", Std = "6th"}
            };
        }
    }
}