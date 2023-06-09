using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherService.DTO;

namespace WeatherService.Endpoints
{
    public class GetCurrentWeatherResponse : CurrentWeather
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public GetCurrentWeatherResponse()
        {
            
        }

        ~GetCurrentWeatherResponse()
        {
            
        }
    }
}