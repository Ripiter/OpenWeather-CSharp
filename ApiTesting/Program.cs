using System;

namespace ApiTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenWeatherApi api = new OpenWeatherApi("7b14dbf4bb8322258a8b3e5e43ba0d3e");

            string city = "Roskilde";

            var results = api.Query(city);

            Console.WriteLine("The temperature in " + city + " is " + results.Main.Temperature.CelsiusCurrent + "C");
            Console.ReadKey();
        }
    }
}
