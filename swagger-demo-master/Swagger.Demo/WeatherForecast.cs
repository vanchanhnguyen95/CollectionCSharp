using System;

namespace Swagger.Demo
{
    public class WeatherForecast
    {
        /// <summary>
        /// Date for the weahter
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Temperature in C
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Temperature in F
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// Summary
        /// </summary>
        public string Summary { get; set; }
    }
}
