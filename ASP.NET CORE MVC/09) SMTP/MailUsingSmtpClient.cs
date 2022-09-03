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
    class MailUsingSmtpClient
    {
        public bool SendEmail(string name, string email, string subject, string message)
        {
            string status = "";
            try
            {
                string from="imhraza023@gmail.com";
                string to = "imhraza023@gmail.com";
                string password = "ikcbxbsemqoupcvk"; //watch this to get your app password  https://youtu.be/J4CtP1MBtOE
                string title="CourseShare";       //title of prjoect.
                string sub = subject+" - Course Share";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(to);
                mail.Subject = sub;
                mail.Body = "<center><h1>"+title+"</h1></center><h3>From: "+name+" - "+email+"</h3><h3>Message:<h3/><p>"+message+"</p>";
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
            if(status == "Mail Sent")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
