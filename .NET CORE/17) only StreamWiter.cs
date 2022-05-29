using System;
using System.IO;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = null;
            try
            {
				//string filename = "data.txt";
				//string filepath = Path.Combine(Environment.CurrentDirectory, filename);
				//StreamWriter sw = new StreamWriter(filepath, append: true);
                sw = new StreamWriter("data.txt",true); //true for append. false or by default create or overwrite file.
                string name = "My name is Hassan";
                sw.WriteLine(name);
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
                sw.Close();
            }
        }
    }
}
