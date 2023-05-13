using System.Text.Json.Serialization;

namespace GeoService.DTO;

public class LocalNames
{
    [JsonPropertyName("el")]
    public string El { get; set; }

    [JsonPropertyName("ar")]
    public string Ar { get; set; }

    [JsonPropertyName("ko")]
    public string Ko { get; set; }

    [JsonPropertyName("et")]
    public string Et { get; set; }

    [JsonPropertyName("es")]
    public string Es { get; set; }

    [JsonPropertyName("ru")]
    public string Ru { get; set; }

    [JsonPropertyName("ms")]
    public string Ms { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("ja")]
    public string Ja { get; set; }

    [JsonPropertyName("zh")]
    public string Zh { get; set; }

    [JsonPropertyName("lv")]
    public string Lv { get; set; }

    [JsonPropertyName("de")]
    public string De { get; set; }

    [JsonPropertyName("oc")]
    public string Oc { get; set; }

    [JsonPropertyName("cs")]
    public string Cs { get; set; }

    [JsonPropertyName("fa")]
    public string Fa { get; set; }

    [JsonPropertyName("eo")]
    public string Eo { get; set; }

    [JsonPropertyName("he")]
    public string He { get; set; }

    [JsonPropertyName("en")]
    public string En { get; set; }

    [JsonPropertyName("km")]
    public string Km { get; set; }

    [JsonPropertyName("it")]
    public string It { get; set; }

    [JsonPropertyName("fr")]
    public string Fr { get; set; }

    [JsonPropertyName("nl")]
    public string Nl { get; set; }

    [JsonPropertyName("vi")]
    public string Vi { get; set; }
}

public class Geocoding
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("local_names")]
    public LocalNames LocalNames { get; set; }

    [JsonPropertyName("lat")]
    public double Lat { get; set; }

    [JsonPropertyName("lon")]
    public double Lon { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }
}

