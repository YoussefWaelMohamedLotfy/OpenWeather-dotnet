using Refit;

namespace OpenWeather.SDK;

/// <summary>
/// Base DTO for OpenWeather DTOs
/// </summary>
public class OpenWeatherBase
{
    /// <summary>
    /// API Key to authorize the request
    /// </summary>
    [AliasAs("appid")]
    public string? ApiKey { get; init; }
}
