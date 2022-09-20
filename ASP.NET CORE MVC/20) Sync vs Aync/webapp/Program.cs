using System;
using System.Threading;            //for Thread.Sleep(1000);
using System.Diagnostics;          //for Stopwatch and timer
using System.Threading.Tasks;      //for Task

namespace webapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Enter 1 for sync.\nEnter 2 for Async.\nEnter your choice:");
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                var timer = Stopwatch.StartNew();

                syncMethodA();
                syncMethodB();
                syncMethodC();

                Console.WriteLine($"Time take: {timer.ElapsedMilliseconds}");
            }
            else if(choice == "2")
            {
                var timer = Stopwatch.StartNew();

                var taskA = asyncMethodA();
                var taskB = asyncMethodB();
                var taskC = asyncMethodC();
                Task[] tasks = { taskA, taskB, taskC };
                Task.WaitAll(tasks);

                Console.WriteLine($"Time take {timer.ElapsedMilliseconds}");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void syncMethodA()
        {
            Console.WriteLine("Starting A......");
            Thread.Sleep(3000);
            Console.WriteLine("Ending A......");
        }

        static void syncMethodB()
        {
            Console.WriteLine("Starting B......");
            Thread.Sleep(2000);
            Console.WriteLine("Ending B......");
        }

        static void syncMethodC()
        {
            Console.WriteLine("Starting C......");
            Thread.Sleep(1000);
            Console.WriteLine("Ending C......");
        }

        static async Task asyncMethodA()
        {
            Console.WriteLine("Starting A......");
            await Task.Delay(3000);
            Console.WriteLine("Ending A......");
        }

        static async Task asyncMethodB()
        {
            Console.WriteLine("Starting B......");
            await Task.Delay(2000);
            Console.WriteLine("Ending B......");
        }

        static async Task asyncMethodC()
        {
            Console.WriteLine("Starting C......");
            await Task.Delay(1000);
            Console.WriteLine("Ending C......");
        }
    }
}
