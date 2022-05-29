using System;


namespace practice
{
	public class Person
    {
        private string name;
        private int age;
        public static string city;// = "Lahore";    //not nessecary to be initialized here.
        public const string COUNTRY = "Pakistan";   // nessecary to be initialized here.   and right side must be constant at compile time. 
        public readonly string hiarColor;

        public Person()
        {
            this.name = default;
            this.age = default;
            this.hiarColor = "Black";              
        }

        public Person(string n, int a)
        {
            this.name = n;
            if (a < 1)
            {
                a = 1;
            }
            this.age = a;
            this.hiarColor = "Black";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                if (age < 1)
                {
                    age = 1;
                }
            }
        }
    }
	
    class Program
    {
        static void Main(string[] args)
        {
            Person.city = "Lahore";         //it can be changed...
            Person p = new Person {Name= "Hassan Raza", Age=21};
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.hiarColor);
            Console.WriteLine(Person.city);
            Console.WriteLine(Person.COUNTRY+"\n");
			
            Person p2 = new Person { Name = "Hussain Raza", Age = 12 };
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Age);
            Console.WriteLine(p2.hiarColor);
            Console.WriteLine(Person.city);
            Console.WriteLine(Person.COUNTRY + "\n");
			
            Person.city = "Islamabad";     //can be changed for all objects. (changed for all objects).
            //Person.COUNTRY = "UK";       //can't be changed
            //p.hiarColor = "White";       //can't be changed
			
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.hiarColor);
            Console.WriteLine(Person.city);
            Console.WriteLine(Person.COUNTRY + "\n")
			
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Age);
            Console.WriteLine(p2.hiarColor);
            Console.WriteLine(Person.city);
            Console.WriteLine(Person.COUNTRY + "\n");
        }
    }
}
