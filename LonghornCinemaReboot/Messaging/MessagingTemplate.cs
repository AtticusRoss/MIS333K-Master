using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace LonghornCinemaReboot.Messaging
{
    public class EmailMessaging
    {
        public static void SendEmail(String toEmailAddress, String emailSubject, String emailBody)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("sp18Team23@gmail.com", "MattSucks"),
                EnableSsl = true
            };
            String finalMessage = emailBody + "\n\n Disclaimer: I don't actually know how to do this. It will be a trip if this actually works. ";
            MailAddress senderEmail = new MailAddress("sp18Team23@gmail.com", "Team 23");

            MailMessage mm = new MailMessage();
            mm.Subject = "Team 23 - " + emailSubject;
            mm.Sender = senderEmail;
            mm.From = senderEmail;
            mm.To.Add(new MailAddress(toEmailAddress));
            mm.Body = finalMessage;
            client.Send(mm);
        }
    }
}