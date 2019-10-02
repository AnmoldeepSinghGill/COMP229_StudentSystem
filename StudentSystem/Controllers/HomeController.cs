using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentSystem.Models;

namespace StudentSystem.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Student testStudent = new Student{FirstName = "Anmol", LastName = "Gill", Email = "asngm@centennial.com", CourseCode = "COMP - 229", FullTime = true, Gpa = 4.28, StudentId = 30145654};
            ViewBag.testStudent = testStudent;
            return View();
        }

        public List<Student> StudentList = new List<Student>();

        public ViewResult ListStudents()
        {
            StudentList.Add(new Student { FirstName = "Anmol", LastName = "Gill", Email = "asngm@centennial.com", CourseCode = "COMP229", FullTime = true, Gpa = 4.28, StudentId = 30145654 });
            StudentList.Add(new Student { FirstName = "Pritpal", LastName = "Singh", Email = "prit@gmail.com", CourseCode = "COMP100", FullTime = true, Gpa = 2.56, StudentId = 30451267 });
            StudentList.Add(new Student { FirstName = "Taran", LastName = "Sohi", Email = "eghah@yahoo.com", CourseCode = "COMP228", FullTime = true, Gpa = 1.23, StudentId = 30245654 });
            StudentList.Add(new Student { FirstName = "Jai", LastName = "Sidhu", Email = "hhddk@hotmail.com", CourseCode = "COMP123", FullTime = false, Gpa = 2.00, StudentId = 30894562 });
            return View(StudentList);
        }

    }
}
