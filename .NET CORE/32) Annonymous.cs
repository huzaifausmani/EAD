using System;
using System.IO;

namespace hello_world
{
    delegate double MathOP(double s,double x);
    
    class Program
    {
        // static double Sum(double x,double y)
        // {
        //     return x+y;
        // }

        // static double Diff(double x,double y)
        // {
        //     return x-y;
        // }

        // static double Mul(double x,double y)
        // {
        //     return x*y;
        // }

        // static double Div(double x,double y)
        // {
        //     return x/y;
        // }

        // static double Mod(double x,double y)
        // {
        //     return x%y;
        // }

        static void Main(string[] args)
        {
            MathOP op = delegate(double a,double b)
            {
                return a+b;
            };

            Console.WriteLine("Sum is: "+op(3,2));

            op += delegate(double a,double b)              //now can't be removed once added by (+=).
            {
                return a-b;
            };

            Console.WriteLine("Difference is: "+op(3,2));
        }
    }
}