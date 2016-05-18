//using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using System.Web.Mvc;
using Lab_4._2_Partial.Models;

namespace Lab_4._2_Partial.Controllers
{
    public class GradeController : Controller
    {
        // GET: Grade
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public PartialViewResult _GradeForStudent(int id)
        {
            List<Grade> grades = ((Student) Session["Student"]).Grades;
            return PartialView(grades);
        }

        public PartialViewResult _AddNewGrade(int id)
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult _AddNewGrade(Grade model)
        {
            ((Student) Session["Student"]).Grades.Add(model);
            return RedirectToAction(actionName: "_GradeForStudent",
                routeValues: new {id = 2});
        }

    }
}