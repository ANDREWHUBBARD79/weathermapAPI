using System;
using System.IO;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using WeatherMapAPI;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string key = File.ReadAllText("jsconfig1.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();


            Console.WriteLine("Please enter your zipcode");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?lat=44.34&lon=10.99&appid={APIKey}";

            Console.WriteLine();

            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees ferenheit in your location.");
        }



    }


}