using System;
using System.Collections;
using System.Linq;



namespace prac
{
    delegate bool del(string s);
    class Program
    {
		static bool findCity(string n)
		{
			return n.Length > 4;
		}
        static void Main(string[] args)
        {
            //1) data source
            var cities = new string[] {"Karachi","ISB","Lahore","Patoki","Peshour","MLTN","KPK"};
            //2)define query
            var query = cities.Where(findCity);
            //3)query execute.
            foreach(var i in query)
            {
                Console.WriteLine(i);
            }
        }
    }
}