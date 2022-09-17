using Refit;

namespace OpenWeather.SDK.Weather;

/// <summary>
/// Weather Endpoints supported in OpenWeather API
/// </summary>
public interface IWeatherApi
{
    /// <summary>
    /// Gets Current Weather for a city
    /// </summary>
    /// <param name="city">City name, State Code, Country Code</param>
    /// <param name="apiKey">Your API Key for authenticating the request</param>
    /// <returns>The Weather Details for the specified City</returns>
    [Get("/weather")]
    Task<IApiResponse> GetWeatherAsync([AliasAs("q")] string city, [AliasAs("appid")] string apiKey);
}
