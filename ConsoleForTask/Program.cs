using System;
using ListOfProject;
using System.Net;
using System.Net.Mail;


namespace ConsoleForTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Smtp data = new Smtp();
            data.send();
        }
    }
}
