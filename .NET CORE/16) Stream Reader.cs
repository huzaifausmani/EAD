using System;
using System.IO;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fin = null;
            StreamReader sr = null;
            try
			{
                fin = new FileStream("data.txt",FileMode.Open);
                sr = new StreamReader(fin);
                Console.WriteLine(sr.ReadLine());
            }
            catch(IOException e)
			{
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
			{
                Console.WriteLine(e.Message);
            }
            finally
			{
                sr.Close();
                fin.Close();
            }
        }
    }
}
