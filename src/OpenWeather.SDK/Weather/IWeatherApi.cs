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
    /// <param name="request"></param>
    /// <returns>The Weather Details for the specified City</returns>
    [Get("/weather")]
    Task<IApiResponse> GetWeatherAsync(CityNameRequest request);

    /// <summary>
    /// Gets Current Weather for a city by Coordinates
    /// </summary>
    /// <param name="request"></param>
    /// <returns>The Weather Details for the specified City</returns>
    [Get("/weather")]
    Task<IApiResponse> GetWeatherAsync(CityCoordinatesRequest request);
}
