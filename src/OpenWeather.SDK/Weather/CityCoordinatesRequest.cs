using Refit;

namespace OpenWeather.SDK.Weather;

/// <summary>
/// City Coordinates Request Object
/// </summary>
public sealed class CityCoordinatesRequest
{
    /// <summary>
    /// City/Area Latitude
    /// </summary>
    [AliasAs("lat")]
    public string? Latitude { get; set; }
        
    /// <summary>
    /// City/Area Longitude
    /// </summary>
    [AliasAs("lon")]
    public string? Longitude { get; set; }
}
