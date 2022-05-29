using System;
using System.IO;

namespace hello_world
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public (string,int) getItemsByTuple()
        {
            return (Name,Age);
        }

        public (string pName,int pAge) getNamedItemsByTuple()
        {
            return (Name,Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name="Hassan";
            p.Age=21;
			
            Console.WriteLine(p.getItemsByTuple().Item1);
            Console.WriteLine(p.getItemsByTuple().Item2);
			
            Person p2 = new Person();
            p2.Name="Ali";
            p2.Age=21;
			
            Console.WriteLine(p2.getNamedItemsByTuple().pName);
            Console.WriteLine(p2.getNamedItemsByTuple().pAge);
        }
    }
}
