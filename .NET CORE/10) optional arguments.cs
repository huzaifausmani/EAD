using System;

namespace hello_world
{
    
    class Program
    {
		
        static int sum(int a, int b, int c=3, int d=4)
        {
            int sum=0;
			sum = a+b+c+d;
			return sum;
        }

        static void Main(string[] args)
        {
            //optional arguments.


            Console.WriteLine(sum(1,2));

        }
    }
}
