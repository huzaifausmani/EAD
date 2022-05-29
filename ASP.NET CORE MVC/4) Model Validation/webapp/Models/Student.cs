using System.IO.Enumeration;
using System.IO;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Name is required.")]
        [Display(Name = "Enter your name: ")]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Age is Required.")]
        [Display(Name = "Enter your age: ")]
        [Range(0, 100)]
        public int? Age { get; set; }

        [Required(ErrorMessage ="CGPA is Required.")]
        [Display(Name = "Enter your cgpa: ")]
        [Range(0, 4.00)]
        public float? CGPA { get; set; }

        [Required(ErrorMessage ="Semester is Required.")]
        [Display(Name = "Enter your semester: ")]
        [StringLength(20, ErrorMessage = "Semester length can't be more than 20.")]
        public string Semester { get; set; }
    }
}
