using System.IO;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class Instructor
    {
        [Required(ErrorMessage ="Name is required.")]
        [Display(Name = "Enter your name: ")]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Subject is required.")]
        [Display(Name = "Enter your Subject: ")]
        [StringLength(50, ErrorMessage = "Subject length can't be more than 50.")]
        public string Subject { get; set; }
    }
}
