using System;
using System.IO;

namespace hello_world
{
    
    class Program
    {
		

        static void Main(string[] args)
        {
            FileStream fout = null;
            StreamWriter sw = null;
            try{
                fout = new FileStream("data.txt",FileMode.Append);
                sw = new StreamWriter(fout);

                string name = "My name is Hassan";

                sw.WriteLine(name);
            }
            catch(IOException e){
                Console.WriteLine(e.Message);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
            finally{
                sw.Close();
                fout.Close();
            }

        }
    }
}


