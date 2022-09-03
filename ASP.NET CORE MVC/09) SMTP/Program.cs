using System.Net;
using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace smtp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // int choice = Int32.Parse(str);

            string choice = "";
            do
            {
                Console.WriteLine("\n\nEnter 1 to send mail using SmtpClient.");
                Console.WriteLine("Enter 2 to send mail using MailKit and MimeKit.");
                Console.WriteLine("Enter 0 to terminate.");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();
                if(choice == "1")
                {
                    MailUsingSmtpClient musc = new MailUsingSmtpClient();
                    if(musc.SendEmail("Hassan Raza","imhraza023@gmail.com","subject of email","This is my mail message."))
                    {
                        Console.WriteLine("Message has been sent.");
                    }
                    else
                    {
                        Console.WriteLine("There was an error in sending your mail. Please try again!");
                    }
                }
                else if(choice == "2")
                {
                    MailUsingMailKit mumk = new MailUsingMailKit();
                    if(mumk.SendEmail("Hassan Raza","imhraza023@gmail.com","subject of email","This is my mail message."))
                    {
                        Console.WriteLine("Message has been sent.");
                    }
                    else
                    {
                        Console.WriteLine("There was an error in sending your mail. Please try again!");
                    }
                }
                else if(choice == "0")
                {
                    Console.WriteLine("OK then bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid choice!");
                }
            } while (choice!="0");
        }
    }
}
