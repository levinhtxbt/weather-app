using Refit;
using WeatherService.DTO;

namespace WeatherService;

public interface IOpenWeatherApi
{
    [Get("/weather?lat={lat}&lon={lon}&appid={apiKey}")]
    Task<CurrentWeather> GetCurrentWeatherAsync(string lat, string lon, string apiKey);

    [Get("/forecast/daily?lat={lat}&lon={lon}&cnt={cnt}&appid={apiKey}")]
    Task<DailyWeather> GetDailyWeatherAsync(string lat, string lon, string apiKey, int cnt = 7);
}