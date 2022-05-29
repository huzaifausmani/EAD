using System;
using System.IO;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            try{
                sr = new StreamReader("data.txt");
                string line = sr.ReadLine();
                while(line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
            catch(IOException e){
                Console.WriteLine(e.Message);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
            finally{
                sr.Close();
            }
        }
    }
}
