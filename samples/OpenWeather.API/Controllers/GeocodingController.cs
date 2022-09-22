using Microsoft.AspNetCore.Mvc;
using OpenWeather.SDK.Geocoding;

namespace OpenWeather.API.Controllers;

/// <summary>
/// Geocoding Services Controller
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class GeocodingController : ControllerBase
{
    private readonly IGeocodingApi _geocodingApi;

    public GeocodingController(IGeocodingApi geocodingApi)
    {
        _geocodingApi = geocodingApi;
    }

    [HttpGet("coordinates")]
    public async Task<IActionResult> GetCoordinatesByName(string cityName, string apiKey)
    {
        var response = await _geocodingApi.GetCityCoordinatesAsync(new()
        {
            ApiKey = apiKey,
            CityName = cityName,
            Limit = 1
        });

        if (response.IsSuccessStatusCode)
            return Ok();

        return StatusCode((int)response.StatusCode);
    }

    [HttpGet("name")]
    public async Task<IActionResult> GetLocationNameByCoordinates(string latitude, string longitude, string apiKey)
    {
        var response = await _geocodingApi.GetLocationNameAsync(new()
        {
            ApiKey = apiKey,
            Latitude = latitude,
            Longitude = longitude,
            Limit = 1
        });

        if (response.IsSuccessStatusCode)
            return Ok();

        return StatusCode((int)response.StatusCode);
    }

    [HttpGet("coordinatesbyZip")]
    public async Task<IActionResult> GetCoordinatesByZipCode(string zipCode, string apiKey)
    {
        var response = await _geocodingApi.GetZipCodeCoordinatesAsync(new()
        {
            ApiKey = apiKey,
            ZipCode = zipCode
        });

        if (response.IsSuccessStatusCode)
            return Ok();

        return StatusCode((int)response.StatusCode);
    }
}
