using System;
using System.IO;

namespace hello_world
{
    
    //Action     (for all void return type function also allow parameters upto 16.)
    //delegate void MyDelegate();
    
	//Func     (for all other return types function also allow parameters upto 16.)
    //delegate double MathOP(double s,double x);

    class Program
    {
        static void show()
        {
            Console.WriteLine("This is some text.");
        }

        static void show2(string s)
        {
            Console.WriteLine(s);
        }

        static void show3(string s,int x)
        {
            Console.WriteLine(s+x);
        }

        static string show4()
        {
            return "This is 4th text.";
        }

        static string show5(int a)
        {
            string s = ""+a;
            return s;
        }
		
        static void Main(string[] args)
        {
            //Action
            Action d1 = show;
            Action<string> d2 = show2;
            Action<string,int> d3 = show3;
            d1();
            d2("This is 2nd text.");
            d3("This is 3rd text.",3);


            //Func
            Func<string> d4 = show4;
            Func<int,string> d5 = show5;
            Console.WriteLine(d4());
            Console.WriteLine(d5(5));
        }
    }
}