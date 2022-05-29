using System;
using System.IO;

namespace hello_world
{
    delegate double MathOP(double s,double x);
    
    class Program
    {
        // static double Sum(double x,double y)
        // {
        //     double s=x+y;
        //     Console.WriteLine("Sum is: "+s);
        //     return s;
        // }

        // static double Diff(double x,double y)
        // {
        //     double d=x-y;
        //     Console.WriteLine("Difference is: "+d);
        //     return d;
        // }

        // static double Mul(double x,double y)
        // {
        //     double m=x*y;
        //     Console.WriteLine("Multiply is: "+m);
        //     return m;
        // }

        // static double Div(double x,double y)
        // {
        //     double d=x/y;
        //     Console.WriteLine("Divide is: "+d);
        //     return d;
        // }

        // static double Mod(double x,double y)
        // {
        //     double m=x%y;
        //     Console.WriteLine("Mod is: "+m);
        //     return m;
        // }

        static void Main(string[] args)
        {
            //Lemda statement.
            MathOP op = (double a,double b) =>
            {
                return a+b;
            };

            Console.WriteLine("Sum is: "+op(3,2));

            op += (double a,double b) =>              //now can't be removed once added by (+=).
            {
                return a-b;
            };

            Console.WriteLine("Difference is: "+op(3,2));

            //Lemda expression.
            op += (double a,double b) => a*b;

            Console.WriteLine("Product is: "+op(3,2));

            op += (double a,double b) => a/b;

            Console.WriteLine("Divide is: "+op(3,2));
        }
    }
}