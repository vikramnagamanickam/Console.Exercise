using System;
using ListOfProject;
using System.Net;
using System.Net.Mail;
using FileReadandWrite;


namespace ConsoleForTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadAndWrite data = new ReadAndWrite();
            data.File();




           // Smtp data = new Smtp();
           //data.send();
        }
    }
}
