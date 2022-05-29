using System;

namespace hello_world
{
    class Program
    {
		static void func1(int []a)
        {
            a[0]=23;
        }

        static void func2(ref int []x)
        {
            x[0]=20;
        }
		
        static void Main(string[] args)
        {
            int []a={1,2,3,4};
            func1(a);                 //actual data modify.
            for (int x=0;x<4;x++)
            {
                Console.WriteLine(a[x]);
            }

            //Arrays can be passed as arguments to method parameters. Because arrays are reference types, the method can change the value of the elements.
            func2(ref a);             //actual data modify.
            for (int x=0;x<4;x++)
            {
                Console.WriteLine(a[x]);
            }
        }
    }
}
