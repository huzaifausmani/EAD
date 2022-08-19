using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
			//Implicit typecasting    char->int->long->float->double
			char a ='A';
			int b=a;
			long c=b;
			float d=c;
			double e=d;
			
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
			Console.WriteLine(d);
			Console.WriteLine(e);
			
			
			//Explicit typecasting
            Console.Write("Enter your age: ");
            string v  = Console.ReadLine();
            
            int age = int.Parse(v);
            Console.WriteLine("Your age is: "+age+".");
        }
    }
}
