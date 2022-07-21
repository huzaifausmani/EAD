using System.Runtime.InteropServices;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.IO.Enumeration;
using System.IO;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.Data.SqlClient;

namespace webapp.Models
{
    public class Student
    {
        public int Sid { get; set; }

        [Display(Name = "Enter your name: ")]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
        [Required(ErrorMessage ="Name is Required.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Age is Required.")]
        [Display(Name = "Enter your age: ")]
        [Range(0, 100)]
        public int? Age { get; set; }

        [Required(ErrorMessage ="CGPA is Required.")]
        [Display(Name = "Enter your cgpa: ")]
        [Range(0, 4.00)]
        public float? CGPA { get; set; }

        [Display(Name = "Enter your semester: ")]
        [StringLength(20, ErrorMessage = "Semester length can't be more than 20.")]
        [Required(ErrorMessage ="Semester is Required.")]
        public string Semester { get; set; }

        public bool addStudent(Student s)
        {
            string constr = @"Server=localhost\SQLEXPRESS;Database=course;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlParameter p1 =new SqlParameter("N",s.Name);
            SqlParameter p2 =new SqlParameter("A",s.Age);
            SqlParameter p3 =new SqlParameter("C",s.CGPA);
            SqlParameter p4 =new SqlParameter("S",s.Semester);
            string querry = $"INSERT INTO Student(name, age, cgpa, semester) values(@N,@A,@C,@S)";
            SqlCommand cmd = new SqlCommand(querry,con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);

            int count = cmd.ExecuteNonQuery();
            if (count>=1)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        
        public List<Student> getStudents()
        {
            string constr = @"Server=localhost\SQLEXPRESS;Database=course;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            string querry = $"SELECT * FROM Student";
            SqlCommand cmd = new SqlCommand(querry,con);

            SqlDataReader dr = cmd.ExecuteReader();

            List<Student> li =new List<Student>();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    Student s = new Student();
                    s.Sid= (int)dr[0];
                    s.Name = dr[1].ToString();
                    s.Age = (int)dr[2];
                    s.CGPA= float.Parse(dr[3].ToString());
                    s.Semester = dr[4].ToString();
                    li.Add(s);
                }
                con.Close();
                return li;
            }
            else
            {
                con.Close();
                return li;
            }
        }

        public Student getStudent(int id)
        {
            string constr = @"Server=localhost\SQLEXPRESS;Database=course;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlParameter p1 =new SqlParameter("I",id);
            string querry = $"SELECT * FROM Student where sid = @I";
            SqlCommand cmd = new SqlCommand(querry,con);
            cmd.Parameters.Add(p1);

            SqlDataReader dr = cmd.ExecuteReader();

            Student std =new Student();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    std.Sid= (int)dr[0];
                    std.Name = dr[1].ToString();
                    std.Age = (int)dr[2];
                    std.CGPA= float.Parse(dr[3].ToString());
                    std.Semester = dr[4].ToString();
                }
            }
            con.Close();
            return std;
        }

        public bool deleteStudent(int id)
        {
            string constr = @"Server=localhost\SQLEXPRESS;Database=course;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlParameter p1 =new SqlParameter("I",id);
            string querry = $"DELETE FROM Student WHERE sid = @I";
            SqlCommand cmd = new SqlCommand(querry,con);
            cmd.Parameters.Add(p1);

            int count = cmd.ExecuteNonQuery();
            if (count>=1)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool IsFloatOrInt(string value)
        {
            int intValue;
            float floatValue;
            return Int32.TryParse(value, out intValue) || float.TryParse(value, out floatValue);
        }
        public bool updateStudent(Student s)
        {
            if(!IsFloatOrInt(s.Age.ToString()) || !IsFloatOrInt(s.CGPA.ToString()))
            {
                return false;
            }
            else
            {
                string constr = @"Server=localhost\SQLEXPRESS;Database=course;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
                SqlConnection con = new SqlConnection(constr);
                con.Open();

                
                SqlParameter p1 =new SqlParameter("N",s.Name);
                SqlParameter p2 =new SqlParameter("A",s.Age);
                SqlParameter p3 =new SqlParameter("C",s.CGPA);
                SqlParameter p4 =new SqlParameter("S",s.Semester);
                SqlParameter p5 =new SqlParameter("I",s.Sid);
                string querry = $"UPDATE Student SET name = @N, age=@A,cgpa=@C,semester=@S WHERE sid = @I";
                SqlCommand cmd = new SqlCommand(querry,con);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);

                int count = cmd.ExecuteNonQuery();
                if (count>=1)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
        }
    }
}
