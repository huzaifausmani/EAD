using System;
using System.IO;

namespace hello_world
{
    delegate void d1();
    delegate void d2(string s);
    delegate string d3(string s);
    delegate double MathOP(double s,double x);
    
    class Program
    {
        static void Display()
        {
            Console.WriteLine("This is first text");
        }

        static void InputError()
        {
            Console.WriteLine("You entered wrong choice.");
        }

        static void Display2(string s)
        {
            Console.WriteLine(s);
        }

        static string Display3(string s)
        {
            Console.WriteLine(s);
            return s;
        }

        static double Sum(double x,double y)
        {
            return x+y;
        }

        static double Diff(double x,double y)
        {
            return x-y;
        }

        static double Mul(double x,double y)
        {
            return x*y;
        }

        static double Div(double x,double y)
        {
            return x/y;
        }

        static double Mod(double x,double y)
        {
            return x%y;
        }

        static double Calculator(MathOP op, double a,double b)    //delegate  as a parameter
        {
            return op(a,b);
        }

        static MathOP assign(int i)            //delegate as retrn type
        {
            if(i==0)
            {
                return Sum;
            }
            else if(i==1)
            {
                return Diff;
            }
            else if(i==2)
            {
                return Mul;
            }
            else if(i==3)
            {
                return Div;
            }
            else if(i==4)
            {
                return Mod;
            }
            else{
                return Sum;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter 0 to display data: ");
            int i = int.Parse(Console.ReadLine());

            d1 del = null;

            if(i==0)
            {
                del = Display;
                del();
            }
            else
            {
                del = InputError;
                del();
            }

            d2 d = Display2;
            d("This is 2nd text");

            d3 dw = Display3;
            string s = dw("This is 3rd text");

            double value = Calculator(Diff,3,4);
            Console.WriteLine(value);

            MathOP op = assign(0);
            double value2 = op(3,4);
            Console.WriteLine(value2);
        }
    }
}