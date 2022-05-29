using System;
using System.IO;

namespace hello_world
{
    class Program
    {
        static int sum(params int[]data)
        {
            int s=0;
            foreach (var item in data)
            {
                s=s+item;
            }
            return s;
        }
        
        static void Main(string[] args)
        {
			//params keyword
            //used for function overloading.
			
            int x=sum(1);
            Console.WriteLine(x);
            x=sum(1,2);
            Console.WriteLine(x);
            x=sum(1,2,3);
            Console.WriteLine(x);
            x=sum(1,2,3,4);
            Console.WriteLine(x);
            x=sum(1,2,3,4,5);
            Console.WriteLine(x);
            x=sum(1,2,3,4,5,6);
            Console.WriteLine(x);
        }
    }
}
