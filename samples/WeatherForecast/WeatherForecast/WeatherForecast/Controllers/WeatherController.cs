using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeatherForecast.Models;

namespace WeatherForecast.Controllers
{
    public class WeatherController : ApiController
    {
        // GET api/weather
        [Authorize]
        public List<Weather> Get()
        {
            List<Weather> OrderList = new List<Weather> 
            {
                new Weather {Id = 1, CountryName = "Dhaka, Bangladesh", Temperature = "88 F" },
                new Weather {Id = 2, CountryName = "Washington, DC", Temperature = "65 F" },
                new Weather {Id = 3, CountryName = "Mumbai, Maharashtra, India", Temperature = "90 F" },
                new Weather {Id = 4, CountryName = "London, UK", Temperature = "56 F" }
            };

            return OrderList;
        }

        // GET api/weather/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/weather
        public void Post([FromBody]string value)
        {
        }

        // PUT api/weather/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/weather/5
        public void Delete(int id)
        {
        }
    }
}
