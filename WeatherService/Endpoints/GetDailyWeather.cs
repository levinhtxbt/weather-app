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
    public class GetDailyWeather : EndpointBaseAsync
        .WithRequest<GetDailyWeatherRequest>
        .WithResult<GetDailyWeatherResponse>
    {
        private readonly IConfiguration _configuration;
        private readonly IOpenWeatherApi _openWeatherApi;
        private readonly ILogger<GetDailyWeather> _logger;

        public GetDailyWeather(IConfiguration configuration, IOpenWeatherApi openWeatherApi, ILogger<GetDailyWeather> logger)
        {
            this._configuration = configuration;
            this._openWeatherApi = openWeatherApi;
            this._logger = logger;
        }

        [HttpGet("/weather/daily")]
        [SwaggerOperation(
            Summary = "Gets the daily weather for a given location",
            Description = "Gets the daily weather for a given location",
            OperationId = "Weather.Daily",
            Tags = new[] { "WeatherEndpoint" })
        ]
        public override async Task<GetDailyWeatherResponse> HandleAsync([FromQuery] GetDailyWeatherRequest request, CancellationToken cancellationToken = default)
        {
            var apiKey = _configuration.GetValue<string>("OpenWeatherApiKey");

            var dailyWeather = await _openWeatherApi.GetDailyWeatherAsync(request.Lat, request.Lon, apiKey);
            
            return dailyWeather.Adapt<GetDailyWeatherResponse>();
        }
    }
}