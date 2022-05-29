using System;

namespace hello_world
{
	public class Student
	{
        public string name;
        public string rollno;
        public int age;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Rollno
        {
            get { return rollno; }
            set { rollno = value; }
        }
		
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
				if(age<0)
                {
                    age=0;
                }
            }
        }
	}
	
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student{
                name="Hassan",
                rollno = "23",
                age=21
            };
            // std1.Name = "Hassan";
            // std1.Rollno = "23";
            // std1.Age = 21;
            Console.WriteLine(std1.Name);
            Console.WriteLine(std1.Rollno);
            Console.WriteLine(std1.Age);
        }
    }
}
