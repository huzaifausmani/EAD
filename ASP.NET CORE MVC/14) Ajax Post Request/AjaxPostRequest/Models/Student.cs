using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AjaxPostRequest.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Name is Required.")]
        [Display(Name = "Enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Age is Required.")]
        [Display(Name = "Enter your age")]
        public int? Age { get; set; }
    }
}