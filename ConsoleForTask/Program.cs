using System;
using ListOfProject;
using System.Net;
using System.Net.Mail;
using FileReadandWrite;
//using JsonReader;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.IO;

using ReadWeatherDataFromJSON;

namespace ConsoleForTask
{
   public class Program
    {
        static void Main(string[] args)
        {


            //  JsonRead data = new JsonRead();
            // data.Climate();



           

                

           var serviceCollection = new ServiceCollection();
            IConfiguration configuration;
           configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsetting.json")
                .Build();
            
            
            serviceCollection.AddSingleton<IConfiguration>(configuration);




          //  ReadJsonData obj = new ReadJsonData();
            //obj.Read();



            //ReadAndWrite data = new ReadAndWrite();
            //  WDdata.File();




           Smtp data1 = new Smtp(configuration);
            data1.FileLog();

        }
    }
}
