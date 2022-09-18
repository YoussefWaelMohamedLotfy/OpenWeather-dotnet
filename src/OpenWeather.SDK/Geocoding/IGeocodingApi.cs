using Refit;

namespace OpenWeather.SDK.Geocoding;

/// <summary>
/// Geocoding supported in OpenWeather API
/// </summary>
public interface IGeocodingApi
{
    /// <summary>
    /// Get Coordinates for a city by name
    /// </summary>
    /// <remarks>
    /// Direct Geocoding allows to get geographical coordinates (lat, lon) by using name of the location (city name or area name).
    /// If you use the limit parameter in the API call, you can cap how many locations with the same name will be seen
    /// in the API response (for instance, London in the UK and London in the US).
    /// </remarks>
    /// <param name="cityName">Name of City to gets its coordinates</param>
    /// <param name="apiKey">Your API Key for authenticating the request</param>
    /// <returns>Coordinates for city desired</returns>
    [Get("/direct")]
    Task<IApiResponse> GetCityCoordinatesAsync([AliasAs("q")] string cityName, [AliasAs("appid")] string apiKey, int limit = 5);

    /// <summary>
    /// Get Coordinates for a Zip Code
    /// </summary>
    /// <param name="zipCode">Zip Code to gets its coordinates</param>
    /// <param name="apiKey">Your API Key for authenticating the request</param>
    /// <returns></returns>
    [Get("/zip")]
    Task<IApiResponse> GetZipCodeCoordinatesAsync([AliasAs("zip")] string zipCode, [AliasAs("appid")] string apiKey);

    /// <summary>
    /// Gets Location name for a City or area
    /// </summary>
    /// <param name="lat">Location Latitude</param>
    /// <param name="lon">Location Longitude</param>
    /// <param name="apiKey">Your API Key for authenticating the request</param>
    /// <param name="limit">Result Count to be retrived</param>
    /// <returns></returns>
    [Get("/reverse")]
    Task<IApiResponse> GetLocationNameAsync(string lat, string lon, [AliasAs("appid")] string apiKey, int limit = 5);
}
