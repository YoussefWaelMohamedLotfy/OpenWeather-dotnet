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
    /// <param name="request"></param>
    /// <returns>Coordinates for city desired</returns>
    [Get("/direct")]
    Task<IApiResponse> GetCityCoordinatesAsync(DirectGeocodingRequest request);

    /// <summary>
    /// Get Coordinates for a Zip Code
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [Get("/zip")]
    Task<IApiResponse> GetZipCodeCoordinatesAsync(ZipCodeGeocodingRequest request);

    /// <summary>
    /// Gets Location name for a City or area
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [Get("/reverse")]
    Task<IApiResponse> GetLocationNameAsync(ReverseGeocodingRequest request);
}
