using System.Text.Json.Serialization;

namespace WeatherService.DTO;

public class City
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("coord")]
    public Coord Coord { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("population")]
    public int Population { get; set; }

    [JsonPropertyName("timezone")]
    public int Timezone { get; set; }
}


