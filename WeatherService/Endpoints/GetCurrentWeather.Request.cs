using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WeatherService.Endpoints
{
    public class GetCurrentWeatherRequest
    {
        [FromQuery]
        public string Lat { get; set; }

        [FromQuery]
        public string Lon { get; set; }
    }
}