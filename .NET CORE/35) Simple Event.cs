using System;

namespace prac
{
    delegate void MyEventhandler();
    class myPublisher
    {
        public event MyEventhandler click;
        public void onClick()
        {
            click.Invoke();
        }
    }

    class mySubscriber
    {
        public static void EventAction()
        {
            Console.WriteLine("Event fired.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myPublisher btn = new myPublisher();
            btn.click += mySubscriber.EventAction;
            btn.onClick();
        }
    }
}