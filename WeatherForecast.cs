using System;
using System.ComponentModel.DataAnnotations;

namespace testSwagger
{
    /// <summary>
    /// 
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public DateTime Date { get; set; }
        ///
        [Required]
        [MaxLength(100)]
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
