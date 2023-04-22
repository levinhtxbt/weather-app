using Microsoft.AspNetCore.Mvc;

namespace GeoService.Controllers
{
    [ApiController]
    [Route("geo")]
    public class GeocodingController : ControllerBase
    {
        private readonly ILogger<GeocodingController> _logger;
        private readonly IOpenWeatherApi _openWeatherApi;
        private readonly IConfiguration _configuration;

        public GeocodingController(
            ILogger<GeocodingController> logger,
            IConfiguration configuration,
            IOpenWeatherApi openWeatherApi)
        {
            _configuration = configuration;
            _openWeatherApi = openWeatherApi;
            _logger = logger;
        }


        [HttpGet("city")]
        public async Task<IActionResult> Get(string city)
        {
            var apiKey = _configuration.GetValue<string>("OpenWeatherApiKey");

            var geocoding = await _openWeatherApi.GetGeocodingAsync(city, apiKey);

            return Ok(geocoding);

        }
    }
}