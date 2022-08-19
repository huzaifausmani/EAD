using System;
using System.Net;
using System.Net.Mail;

namespace smtp
{
    class Program
    {
        static void Main(string[] args)
        {
            string status = "";
            try
            {
                string from="sender@gmail.com";
                string password = "appPassword";//watch this to get your app password  https://youtu.be/J4CtP1MBtOE
                string sub = "Subject of email";
                string title="CourseShare";       //title of prjoect.

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add("reciever@gmail.com");
                mail.Subject = sub;
                mail.Body = "<h1>"+title+"</h1><p>Message Body......</p>";
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
                smtp.Credentials = new System.Net.NetworkCredential(from,password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                status = "Mail Sent";
            }
            catch(Exception ex)
            {
                status = ex.Message;
            }
            Console.WriteLine(status);
        }
    }
}
