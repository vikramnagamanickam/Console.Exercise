using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.IO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ListOfProject
{
    public class Smtp
    {

        private readonly IConfiguration configuration;
        public Smtp(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        string body = $"this is main email @{DateTime.UtcNow:F}";
        public void BodyWriter()
        {
            try
            {
                string Filepath = "C:\\Users\\Admin\\source\\repos\\ConsoleForTask\\ConsoleForTask\\WeatherForecast-Result (2).json";
                string Json = File.ReadAllText(Filepath);
                List<WeatherForeCast> Result = JsonConvert.DeserializeObject<List<WeatherForeCast>>(Json);
                foreach (var source in Result)
                {
                    body += $"date:{source.Date},summary:{source.summary},tempratureC:{source.TempratureC},tempratureF:{source.TempratureF} \n";
                }
            }
            catch(Exception e)
            {
                body += e;
            }
        }
        public void FileLog()
        {
            string file = $"File_{DateTime.Now.ToString("yyyy-MM-dd")}.txt";
            try
            {
                BodyWriter();
                send();
                StreamWriter sw = new StreamWriter($"D:{file}.txt",false);
                
                sw.WriteLine($"Successfully sent Mail in{DateTime.Now.ToString("yyyy-MM-dd")}");
                sw.Close();
            }
            catch (Exception e)
            {
                StreamWriter sw1 = new StreamWriter($"D:{file}.txt",false);
                sw1.WriteLine(e.StackTrace);
                sw1.Close();
            }
        }
        public void send()
        {
            Console.WriteLine("Hello World!");
            SendEmail(GetUserName(), GetPassword());
          

        }

        public  void SendEmail(string fromAddress, string password)
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
            string subject = "reminder";
           
            try
            {
                Console.WriteLine($" {fromAddress}, {ToAddress()}{ subject}{body}");
                Console.WriteLine("sending email ");
                email.Send(fromAddress, ToAddress(), subject, body);
                Console.WriteLine("email sent ");
            }
            catch (SmtpException e)
            {
                throw;
            }

        }
        public  string GetUserName()
        {
            var dataFromjsonFile = configuration.GetSection("From").Value;
            return dataFromjsonFile;
            
        }
        public static string GetPassword()
        {
            return "nzkrwtkssqzcuwal";
        }
        public  string ToAddress()
        {
            var dataFromjsonFile1 = configuration.GetSection("To").Value;
            return dataFromjsonFile1;
           // return "Sureshkumar.duraisamy@AnaiyaanTechnologies.com";
        }
       
    }
}
