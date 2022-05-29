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

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public override string ToString()
        {
            return this.Name+" "+this.Age+" "+this.Address;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person{Name="Abbas",Age=15,Address="Lahore"};
            Console.WriteLine(p);
        }
    }
}