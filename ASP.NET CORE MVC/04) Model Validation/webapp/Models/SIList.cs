using System.Linq.Expressions;
using System.ComponentModel;
using System.IO;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace webapp.Models
{
    public class SIList
    {
        public static List<Student> slist = new List<Student>();
        public static List<Instructor> ilist = new List<Instructor>();

        public static void AddStudent(Student s)
        {
            slist.Add(s);
        }

        public static void AddInstructor(Instructor i)
        {
            ilist.Add(i);
        }

        public static List<Student> getStudents()
        {
            return slist;
        }

        public static List<Instructor> getInstructors()
        {
            return ilist;
        }
    }
}
