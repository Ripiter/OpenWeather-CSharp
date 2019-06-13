using System;
using Newtonsoft.Json.Linq;


namespace ApiTesting
{
    public class Main
    {
        //Temperature that we get from json is set in kelvin
        //so we convert it to celsius
        private TemperatureC temperature;

        public TemperatureC Temperature { get => temperature; set => temperature = value; }

        public Main(JToken maindata)
        {
            Temperature = new TemperatureC(double.Parse(maindata.SelectToken("temp").ToString()));
        }

    }
    public class TemperatureC
    {
        private double celsiusCurrent;
        private double kelvinCurrent;

        public double CelsiusCurrent { get => celsiusCurrent; set => celsiusCurrent = value; }

        public TemperatureC(double temperature)
        {
            this.kelvinCurrent = temperature;
            CelsiusCurrent = convertToCelsius(this.kelvinCurrent);
        }


        private double convertToCelsius(double kelvin)
        {
            return Math.Round(kelvin - 273.15, 3);
        }
    }
}
