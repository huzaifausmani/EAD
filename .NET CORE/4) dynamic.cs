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
            //dynamic datatype.
            //it's an explicit datatype.
            //not necessary to be intialized always at the time of creation.
            //can be modified after-wards.
            //run time
            dynamic x;
            x ="some string";
            
            Console.WriteLine(x);
            x = 1;   //no error
            Console.WriteLine(x);

            dynamic y = func();                //we can do this but its not a good practice.
            Console.WriteLine(y);              //not easily readable.

            y="abc";
            Console.WriteLine(y);              //not easily readable.
        }
    }
}
