using System;

namespace ApiTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenWeatherApi api = new OpenWeatherApi("Your-api-key");

            string city = "Roskilde";

            var results = api.Query(city);

            Console.WriteLine("The temperature in " + city + " is " + results.Main.Temperature.CelsiusCurrent + "C");
            Console.ReadKey();
        }
    }
}
