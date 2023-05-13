using GeoService.DTO;
using Refit;

namespace GeoService;
public interface IOpenWeatherApi
{

    [Get("/geo/1.0/direct?q=city&limit={limit}&appid={apiKey}")]
    Task<List<Geocoding>> GetGeocodingAsync(string city, string apiKey, int limit = 10);

}