using Refit;

namespace OpenWeather.SDK.Geocoding;

/// <summary>
/// Direct Geocoding Request that accepts City name and an optional result limit
/// </summary>
public sealed class DirectGeocodingRequest : OpenWeatherBase
{
    [AliasAs("q")] 
    public string? CityName { get; init; }

    public int Limit { get; init; } = 5;
}
