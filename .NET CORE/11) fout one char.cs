using System;
using System.IO;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fout = null;
            try
			{
				//Create    overwrite file if already exist.
				//CreateNew  throughs exception if already exist.
                fout = new FileStream("data.txt",FileMode.Create);
                fout.WriteByte((byte)'A');
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
                fout.close();
            }
        }
    }
}
