using System;

namespace hello_world
{
    class Program
    {
        static int func()
        {
            return 1;
        }
        static void Main(string[] args)
        {
            //var datatype
            //it's an implicit datatype.
            //intialized always at the time of creation.
            //can't be modified once created.
            //compile time
            var x ="some string";
            Console.WriteLine(x);

			x="anything";
			Console.WriteLine(x);
            //x = 1;   //error

            var y = func();                //we can do this but its not a good practice.
            Console.WriteLine(y);          //not easily readable.
        }
    }
}
