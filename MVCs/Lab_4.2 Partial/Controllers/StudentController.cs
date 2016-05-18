//using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using System.Web.Mvc;
using Lab_4._2_Partial.Models;

namespace Lab_4._2_Partial.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Details()
        {
            Student student = new Student()
            {
                StudentId = 1,
                Name = "Johan",
                LastName = "Bottern",
                Personnumber = "80000000",
                Address = "Where ever I want 56",
                Grades = new List<Grade>()
                {
                    new Grade()
                    {
                        GradeId = 2,
                        CourseName = "MVC",
                        GraceValue = "G"
                    }
                }
            };
            Session["Student"] = student;
            return View(student);
        }
    }
}