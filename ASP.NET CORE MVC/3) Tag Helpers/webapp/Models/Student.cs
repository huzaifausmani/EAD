using System.IO;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace webapp.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float CGPA { get; set; }
        public string Semester { get; set; }
    }
}
