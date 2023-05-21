using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace WeatherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter city: ");
            string city = Console.ReadLine();

            WebRequest webRequest = WebRequest.Create($"http://api.openweathermap.org/data/2.5/weather?q={city}&appid=yourToken&units=metric");
            webRequest.ContentType = "text/json";
            webRequest.Method = "GET";

            try
            {
                WebResponse response = webRequest.GetResponse(); ;


                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    var result = sr.ReadToEnd();


                    RootObject weather = JsonConvert.DeserializeObject<RootObject>(result);
                    weather.PrintWeather();
                }
            }
            catch(WebException we)
            {
                Console.WriteLine(we.Message);
            }


        }
    }
}
