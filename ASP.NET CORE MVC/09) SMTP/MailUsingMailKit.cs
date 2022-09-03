using System;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

//must have to include these above namespaces.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace smtp
{
    class MailUsingMailKit
    {
        public bool SendEmail(string name, string email, string subject, string message)
        {
            string status = "";
            try
            {
                //add two packages first:
                // dotnet add package MimeKit --version 3.4.0
                // dotnet add package MailKit --version 3.3.0

                // visit following website to get your SMTP credentials: 
                // https://ethereal.email/

                string from="imhraza023@gmail.com";
                string to = "imhraza023@gmail.com";
                string password = "ikcbxbsemqoupcvk"; //watch this to get your app password  https://youtu.be/J4CtP1MBtOE
                string sub = subject;
                string title="CourseShare";       //title of prjoect.

                // create email message
                var emailClient = new MimeMessage();
                emailClient.From.Add(MailboxAddress.Parse(from));
                emailClient.To.Add(MailboxAddress.Parse(to));
                emailClient.Subject = sub;
                emailClient.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = "<center><h1>"+title+"</h1></center><h3>From: "+name+" - "+email+"</h3><h3>Message:<h3/><p>"+message+"</p>" };

                // send email
                using (var smtp = new SmtpClient())
                {
                    smtp.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    smtp.Authenticate(from, password);
                    smtp.Timeout = 100000;
                    smtp.Send(emailClient);
                    smtp.Disconnect(true);
                }

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
