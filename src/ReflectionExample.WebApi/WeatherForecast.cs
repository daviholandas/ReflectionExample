using System;

namespace ReflectionExample.WebApi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }


        private int SumOfTemperatures(int temperature1, int temperature2)
            => temperature1 + temperature2;
    }
}
