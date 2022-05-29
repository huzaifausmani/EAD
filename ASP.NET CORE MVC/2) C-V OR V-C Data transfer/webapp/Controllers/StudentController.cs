using System.Collections;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapp.Models;

namespace webapp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult studentform()
        {
            return View();
        }

        [HttpPost]
        public IActionResult studentform(string name,int age,float cgpa,string semester)
        {
            Student s = new Student{Name=name,Age=age,CGPA=cgpa,Semester=semester};
            SIList.AddStudent(s);
            return View("studentform",s);
        }

        public IActionResult studentdata()
        {
            ViewBag.x="This is data from ViewBag...";
            ViewData["data"] = "This is data from ViewData....";
            List<Student> list = SIList.getStudents();
            return View("studentdata",list);                //This is data from Model...(list)
        }

        [HttpGet]
        public IActionResult instructorform()
        {
            return View();
        }

        [HttpPost]
        public IActionResult instructorform(string name,string subject)
        {
            Instructor i = new Instructor{Name=name,Subject=subject};
            SIList.AddInstructor(i);
            return View("instructorform",i);
        }

        public IActionResult instructordata()
        {
            ViewBag.x="This is data from ViewBag...";
            ViewData["data"] = "This is data from ViewData....";
            List<Instructor> list = SIList.getInstructors();
            return View("instructordata",list);                //This is data from Model...(list)
        }
    }
}
