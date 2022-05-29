using System;


//sirf publisher ma invoke karna
//sirf  =+ sa add ho ga event ka sath (otherwise sara khatam ho sakta hain dosri classes ma)

namespace prac
{
    delegate void hnadler(string s);
    class myPublisher
    {
        public event hnadler msgevent=null;   //define
        public void publishMessage(string msg)  //raise
        {
            msgevent.Invoke(msg);
        }
    }

    class myEmailSubscriber
    {
        public void subscribe(myPublisher p)
        {
            p.msgevent += sendMessage;

            //if (p.msgevent == null)
            //{
            //    p.msgevent = sendMessage;
            //}
            //else
            //{
            //    p.msgevent += sendMessage;
            //}
        }
        private void sendMessage(string m)
        {
            Console.WriteLine($"Send to email {m}");
        }
    }

    class myMobileSubscriber
    {
        public void subscribe(myPublisher p)
        {
            p.msgevent += sendMessage;
            //if (p.msgevent == null)
            //{
            //    p.msgevent = sendMessage;
            //}
            //else
            //{
            //    p.msgevent += sendMessage;
            //}
        }
        private void sendMessage(string m)
        {
            Console.WriteLine($"Send to mobile {m}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            myPublisher pub = new myPublisher();
            myEmailSubscriber em = new myEmailSubscriber();
            myMobileSubscriber mb = new myMobileSubscriber();

            em.subscribe(pub);
            mb.subscribe(pub);

            pub.publishMessage("yes");
        }
    }
}