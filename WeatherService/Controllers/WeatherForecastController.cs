using Microsoft.AspNetCore.Mvc;
using WeatherService.DTO;

namespace WeatherService.Controllers;

[ApiController]
[Route("weather")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IOpenWeatherApi _openWeatherApi;
    private readonly IConfiguration _configuration;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration configuration, IOpenWeatherApi openWeatherApi)
    {
        _configuration = configuration;
        _openWeatherApi = openWeatherApi;
        _logger = logger;
    }

    [HttpGet("current")]
    public async Task<IActionResult> Get(string lat, string lon)
    {
        var apiKey = _configuration.GetValue<string>("OpenWeatherApiKey");

        var currentWeather = await _openWeatherApi.GetCurrentWeatherAsync(lat, lon, apiKey);

        return Ok(currentWeather);

    }

    [HttpGet("daily")]
    public async Task<IActionResult> GetDailyWeather(string lat, string lon, int cnt)
    {
        var apiKey = _configuration.GetValue<string>("OpenWeatherApiKey");

        var dailyWeather = await _openWeatherApi.GetDailyWeatherAsync(lat, lon, apiKey);

        return Ok(dailyWeather);

    }




}
