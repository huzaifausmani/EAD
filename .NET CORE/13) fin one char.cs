using System;
using System.IO;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fin = null;
            try
			{
                fin = new FileStream("data.txt",FileMode.Open);
				int i = fin.ReadByte();
                char ch = (char)i;
                Console.WriteLine(ch);
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
                fin.Close();
            }
        }
    }
}
