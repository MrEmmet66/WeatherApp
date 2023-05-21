using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    class Main
    {
        public string Temp { get; set; }
        public string Feels_Like { get; set; }
        public string Temp_Min { get; set; }
        public string Temp_Max { get; set; }
        public string Pressure { get; set; }
        public string Humidity { get; set; }
    }
    class RootObject
    {
        public List<Weather> Weather { get; set; }
        public Main Main { get; set; }


        public string Name { get; set; }

        public void PrintWeather()
        {
            Console.WriteLine($"**************Weather for: {Name}**************");
            Console.WriteLine($"Temperature: {Main.Temp} °C, feels like {Main.Feels_Like} °C");
            Console.WriteLine($"Max temp: {Main.Temp_Max} °C; Min temp: {Main.Temp_Min} °C");
            Console.WriteLine($"Pressure: {Main.Pressure} hPa");
            Console.WriteLine($"Air humidity: {Main.Humidity}%");
            foreach(Weather w in Weather)
            {
                Console.WriteLine($"Weather: {w.Main}");
                Console.WriteLine($"Weather description: {w.Description}");
            }
        }
    }


}
