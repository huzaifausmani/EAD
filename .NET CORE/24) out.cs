using System;
using System.IO;

namespace hello_world
{
    class Program
    {
        public static double squareRoot(double a,out double b)
        {
            double x=a;
            a=Math.Sqrt(x);
            b=Math.Sqrt(x)*-1;
            return a;
        }
        static void Main(string[] args)
        {
            double a=4;
            double b;
            Console.WriteLine(squareRoot(a,out b));
            Console.WriteLine(b);
        }
    }
}