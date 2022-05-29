using System;
using System.IO;

namespace hello_world
{
    class Program
    {
		static void fileRead(string filename)
		{
            FileStream fin = null;                       
            FileStream fout = null;
            try
			{
                fin = new FileStream(filename,FileMode.Open);
                fout = new FileStream("data2.txt",FileMode.Create);
                int i = fin.ReadByte();
                while(i!=-1)
                {
                    char ch = (char)i;
                    fout.WriteByte((Byte)ch);
                    Console.Write(ch+" ");
                    Console.WriteLine(i);
                    i = fin.ReadByte();
                }
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
                fin.Close();
            }
        }
        static void Main(string[] args)
        {
            string filename = "data.txt";
            fileRead(filename);
        }
    }
}
