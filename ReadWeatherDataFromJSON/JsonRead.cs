using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWeatherDataFromJSON
{
    public class JsonRead
    {
        public void Climate()
        {
            string Filepath = "C:\\Users\\Admin\\source\\repos\\ConsoleForTask\\ConsoleForTask\\WeatherForecast-Result (2).json";
            string Json = File.ReadAllText(Filepath);
            List<WeatherForeCast> Result = JsonConvert.DeserializeObject<List<WeatherForeCast>>(Json);
            foreach (var source in Result)
            {
                Console.WriteLine($"date:{source.Date},summary:{source.summary},tempratureC:{source.TempratureC},tempratureF:{source.TempratureF}");

            }
        }
    }
}

