using System;

namespace ReadWeatherDataFromJSON
{
    public class WeatherForeCast
    {
        public DateTime Date { get; set; }
        public int TempratureC { get; set; }
        public int TempratureF { get; set; }
        public string summary { get; set; }

    }
}
