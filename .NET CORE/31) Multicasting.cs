using System;
using System.IO;

namespace hello_world
{
    delegate double MathOP(double s,double x);
    
    class Program
    {
        static double Sum(double x,double y)
        {
            double s=x+y;
            Console.WriteLine("Sum is: "+s);
            return s;
        }

        static double Diff(double x,double y)
        {
            double d=x-y;
            Console.WriteLine("Difference is: "+d);
            return d;
        }

        static double Mul(double x,double y)
        {
            double m=x*y;
            Console.WriteLine("Multiply is: "+m);
            return m;
        }

        static double Div(double x,double y)
        {
            double d=x/y;
            Console.WriteLine("Divide is: "+d);
            return d;
        }

        static double Mod(double x,double y)
        {
            double m=x%y;
            Console.WriteLine("Mod is: "+m);
            return m;
        }

        static void Main(string[] args)
        {
            MathOP op = Sum;
            op += Diff;
            op += Mul;
            op += Div;
            op += Mod;

            double v1 = op.Invoke(3,2);
            Console.WriteLine("Last function added is Mod: "+v1);

            op -= Diff;
            op -= Mul;
            op -= Div;
            op -= Mod;

            double v2 = op(3,2);
            Console.WriteLine("Last function added is Sum: "+v2);
        }
    }
}