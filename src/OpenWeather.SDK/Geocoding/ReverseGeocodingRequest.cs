using Refit;

namespace OpenWeather.SDK.Geocoding;

/// <summary>
/// Reverse Geocoding Request that accepts Coordinates and an optional result limit
/// </summary>
public sealed class ReverseGeocodingRequest : OpenWeatherBase
{
    [AliasAs("lat")]
    public string? Latitude { get; init; }

    [AliasAs("lon")]
    public string? Longitude { get; init; }

    public int Limit { get; init; } = 5;
}
