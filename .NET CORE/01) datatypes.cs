using System;
using System.IO;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=1;               //4bytes     //32-bit signed integer type
            float y=2.3F;          //4bytes     //32-bit single-precision floating point type
            long b = 2L;           //8bytes
            double z=3.45;         //8bytes     //64-bit double-precision floating point type    3.45D bhi chala ga
            decimal a=3.2M;        //16bytes    //128-bit precise decimal values with 28-29 significant digits
			
            char c = 'A';                         //2 bytes (16 bits)  65
            string d = "qwertyuiop";              //2 bytes each char
			
			int e=-1;
            bool  isGreat = Convert.ToBoolean(e);               //1 byte     
			
			object n =12;
            Console.WriteLine(n);
            Console.WriteLine(n.ToString().Length);
			
			Console.WriteLine(isGreat);
			
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
			
			int []data = {1,2,3,4,5,6,7,8,9};
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}