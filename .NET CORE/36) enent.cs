using System;
using System.IO;
using Microsoft.Data.SqlClient;


namespace practice
{
    delegate void EventHandler();              //delegate
	
    class myButton                             //publisher
    {
        public event EventHandler click;       //define

        public void onClick()
        {
            click.Invoke();                    //raise
        }
    }
	
    class mySubscriber                         //subscriber(listener).
    {
        public static void myEventFunc()       //must be static to call in static main.
        {
            Console.WriteLine("method executed.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myButton button = new myButton();
            button.click += mySubscriber.myEventFunc;
            button.click += () => Console.WriteLine("2nd method executed.");
            button.click += () => Console.WriteLine("3rd method executed.");
            
            button.onClick();
        }
    }
}