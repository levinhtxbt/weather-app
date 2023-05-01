using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Mapster;

namespace WeatherService.Endpoints
{
    public class GetCurrentWeather : EndpointBaseAsync
    .WithRequest<GetCurrentWeatherRequest>
    .WithResult<GetCurrentWeatherResponse>
    {
        private readonly IConfiguration _configuration;
        private readonly IOpenWeatherApi _openWeatherApi;

        public GetCurrentWeather(IConfiguration configuration, IOpenWeatherApi openWeatherApi)
        {
            this._configuration = configuration;
            this._openWeatherApi = openWeatherApi;
        }
        [HttpGet("/weather/current")]
        [SwaggerOperation(
            Summary = "Get current weather base on lat/lon",
            Description = "Get current weather base on lat/lon",
            OperationId = "Weather.GetCurrent",
            Tags = new[] { "WeatherEndpoint" })]
        public override async Task<GetCurrentWeatherResponse> HandleAsync([FromQuery] GetCurrentWeatherRequest request, CancellationToken cancellationToken = default)
        {
            var apiKey = _configuration.GetValue<string>("OpenWeatherApiKey");
            var currentWeather = await _openWeatherApi.GetCurrentWeatherAsync(request.Lat, request.Lon, apiKey);
            return currentWeather.Adapt<GetCurrentWeatherResponse>();
        }
    }
}