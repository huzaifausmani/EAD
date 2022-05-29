using System;

namespace hello_world
{
    class Program
    {
		static void func1(int a)
        {
            a=20;
        }

        static void func2(ref int x)
        {
            x=20;
        }
		
        static void Main(string[] args)
        {
            int a=10;
            func1(a);                 //by value new copy.
            Console.WriteLine(a);
            func2(ref a);             //actual data modify.
            Console.WriteLine(a);
        }
    }
}
