using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace ListOfProject
{
    public class Smtp
    {
        public void send()
        {
            Console.WriteLine("Hello World!");
            SendEmail(GetUserName(), GetPassword());
            Console.ReadLine();
        }

        public static void SendEmail(string fromAddress, string password)
        {
            using SmtpClient email = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential(userName: fromAddress, password),

            };
            string subject = "youtube";
            string body = $"this is main email @{DateTime.UtcNow:F}";
            try
            {
                Console.WriteLine("sending email ");
                email.Send(fromAddress, ToAddress(), subject, body);
                Console.WriteLine("email sent ");
            }
            catch (SmtpException e)
            {
                Console.WriteLine(e);
            }

        }
        public static string GetUserName()
        {
            return "nagamanickamvikram@gmail.com";
            
        }
        public static string GetPassword()
        {
            return "nzkrwtkssqzcuwal";
        }
        public static string ToAddress()
        {
            return "Sureshkumar.duraisamy@AnaiyaanTechnologies.com";
        }
    }
}
