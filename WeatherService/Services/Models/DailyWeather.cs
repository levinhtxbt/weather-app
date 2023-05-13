using System.Text.Json.Serialization;

namespace WeatherService.DTO;

public class List
{
    [JsonPropertyName("dt")]
    public int Dt { get; set; }

    [JsonPropertyName("sunrise")]
    public int Sunrise { get; set; }

    [JsonPropertyName("sunset")]
    public int Sunset { get; set; }

    [JsonPropertyName("temp")]
    public Temp Temp { get; set; }

    [JsonPropertyName("feels_like")]
    public FeelsLike FeelsLike { get; set; }

    [JsonPropertyName("pressure")]
    public int Pressure { get; set; }

    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }

    [JsonPropertyName("weather")]
    public List<Weather> Weather { get; set; }

    [JsonPropertyName("speed")]
    public double Speed { get; set; }

    [JsonPropertyName("deg")]
    public int Deg { get; set; }

    [JsonPropertyName("gust")]
    public double Gust { get; set; }

    [JsonPropertyName("clouds")]
    public int Clouds { get; set; }

    [JsonPropertyName("pop")]
    public double Pop { get; set; }

    [JsonPropertyName("rain")]
    public double? Rain { get; set; }
}

public class DailyWeather
{
    [JsonPropertyName("city")]
    public City City { get; set; }

    [JsonPropertyName("cod")]
    public string Cod { get; set; }

    [JsonPropertyName("message")]
    public double Message { get; set; }

    [JsonPropertyName("cnt")]
    public int Cnt { get; set; }

    [JsonPropertyName("list")]
    public List<List> List { get; set; }
}


