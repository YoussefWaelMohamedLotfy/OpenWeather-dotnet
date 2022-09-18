using Refit;

namespace OpenWeather.SDK.Weather;

/// <summary>
/// Weather Endpoints supported in OpenWeather API
/// </summary>
public interface IWeatherApi
{
    /// <summary>
    /// Gets Current Weather for a city by Name
    /// </summary>
    /// <param name="city">City name, State Code, Country Code</param>
    /// <param name="apiKey">Your API Key for authenticating the request</param>
    /// <returns>The Weather Details for the specified City</returns>
    [Get("/weather")]
    Task<IApiResponse> GetWeatherAsync([AliasAs("q")] string city, [AliasAs("appid")] string apiKey);

    /// <summary>
    /// Gets Current Weather for a city by Coordinates
    /// </summary>
    /// <param name="latitude">City or Area Latitude</param>
    /// <param name="longitude">City or Area Longitude</param>
    /// <param name="apiKey">Your API Key for authenticating the request</param>
    /// <returns>The Weather Details for the specified City</returns>
    [Get("/weather")]
    Task<IApiResponse> GetWeatherAsync([AliasAs("lat")] string latitude, [AliasAs("lon")] string longitude, [AliasAs("appid")] string apiKey);
}
