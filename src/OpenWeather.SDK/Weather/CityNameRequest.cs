using Refit;

namespace OpenWeather.SDK.Weather;

/// <summary>
/// City Name Request Object
/// </summary>
public sealed class CityNameRequest : OpenWeatherBase
{
    /// <summary>
    /// City name to get weather for
    /// </summary>
    [AliasAs("q")]
    public string? CityName { get; init; }
}
