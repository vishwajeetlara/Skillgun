using EyeDoctor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace EyeDoctor.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetallStudent()
        {
            var student = Students();
            return View(student);
        }

        public ActionResult GetStudent(int id)
        {
            var student = Students().FirstOrDefault(x => x.Studenet_Id == id);
            return View(student);
        }

        public ActionResult GetStudentAddress(int id)
        {
            var student = Students().FirstOrDefault(x => x.Studenet_Id == id);
            return View(student);
        }
        private List<StudentModel> Students()
        {
            return new List<StudentModel>()
           {
               new StudentModel()
               {
                   Studenet_Id=101,
                   Student_Name="raja",
                   Student_Email="raja@gmail.com"
               },
               new StudentModel()
               {
                   Studenet_Id=102,
                   Student_Name="ram",
                   Student_Email="ram@gmail.com"
               },

               new StudentModel()
               {
                   Studenet_Id=103,
                   Student_Name="ram",
                   Student_Email="ram@gmail.com"
               },
           };

        }

    }
}