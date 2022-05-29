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
                //Append        we know it.
                fout = new FileStream("data.txt",FileMode.Create);
                char ch='A';
                for (var i = 0; i < 26; i++)
                {
                    fout.WriteByte((byte)ch);
                    ch++;
                }
                // for (char i='A';i<='Z';i++)
				// {
				// 	fout.WriteByte((byte)i);
				// }
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
                fout.Close();
            }
        }
    }
}
