using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherForecast.Models
{
    public class Weather
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string Temperature { get; set; }
    }
}