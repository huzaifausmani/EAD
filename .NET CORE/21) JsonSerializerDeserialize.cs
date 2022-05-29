using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
//dotnet add package System.Text.Json --version 6.0.2     (https://www.nuget.org/packages/System.Text.Json)

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
            StreamReader sr= new StreamReader("jsonFile.txt");
            string data = sr.ReadLine();
            Person p=new Person();
            while (data!=null)
            {
                p=JsonSerializer.Deserialize<Person>(data);
                Console.WriteLine(p);
                data = sr.ReadLine();
            }
            sr.Close();
        }
    }
}