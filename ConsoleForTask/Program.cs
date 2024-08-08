using System;
using ListOfProject;
using System.Net;
using System.Net.Mail;
using FileReadandWrite;
using JsonReader;

namespace ConsoleForTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadJsonData obj = new ReadJsonData();
            obj.Read();



            //ReadAndWrite data = new ReadAndWrite();
            //  WDdata.File();




            // Smtp data1 = new Smtp();
            //data1.FileLog();

        }
    }
}
