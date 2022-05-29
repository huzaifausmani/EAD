using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;
using System.ComponentModel;
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
        public IActionResult studentform(Student s) //(string name,int age,float cgpa,string semester)
        {
            if(ModelState.IsValid)                       // using model validation.
            {
                //Student s = new Student{Name=Name,Age =Age,CGPA=CGPA,Semester=Semester};
                bool flag = s.addStudent(s);
                if(flag)
                {
                    ViewBag.show = "Student added";
                }
                else
                {
                    ViewBag.show = "Student not added";
                }
                return View("studentform");
            }
            else
            {
                ModelState.AddModelError(string.Empty,"Please enter correct data"); //defined Model Error
                return View();
            }
        }

        public IActionResult studentdata()
        {
            Student s = new Student();
            List<Student> list = s.getStudents();
            return View("studentdata",list);                //This is data from Model...(list)
        }

        public IActionResult details(int id)     //must use id here.
        {
            Student s = new Student();
            // List<Student> list = s.getStudents();
            // s = list.Find(s=>s.Sid==id);
            s=s.getStudent(id);
            return View("details",s);
        }

        public IActionResult delete(int id)     //must use id here.
        {
            List<Student> list = new List<Student>();
            Student s = new Student();
            bool flag =s.deleteStudent(id);
            if(flag)
            {
                ViewBag.show="Successfully deleted";
                list = s.getStudents();
                return View("studentdata",list);
            }
            else
            {
                ViewBag.show="Not deleted";
                list = s.getStudents();
                return View("studentdata",list);
            }
        }

        [HttpGet]
        public IActionResult update(int id)     //must use id here.
        {
            Student s = new Student();
            List<Student> list = s.getStudents();
            s = list.Find(s=>s.Sid==id);
            return View("update",s);
        }

        [HttpPost]
        public IActionResult update(Student std)     //must use id here.
        {
            // foreach (var item in list)
            // {
            //     if (item.Sid==std.Sid)
            //     {
            //         item.Name = std.Name;
            //         item.Age = std.Age;
            //         item.CGPA = std.CGPA;
            //         item.Semester = std.Semester;
            //         break;
            //     }
            // }

            Student s = new Student();
            bool flag =s.updateStudent(std);
            List<Student> list =  new List<Student>();
            //return View("studentdata",list);
            if(flag)
            {
                ViewBag.show2="Successfully updated";
                list = s.getStudents();
                return View("studentdata",list);
            }
            else
            {
                ViewBag.show2="Not updated";
                list = s.getStudents();
                return View("studentdata",list);
            }
        }
    }
}
