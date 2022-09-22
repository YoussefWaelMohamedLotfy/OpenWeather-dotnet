using Microsoft.AspNetCore.Mvc;
using OpenWeather.SDK.Weather;

namespace OpenWeather.API.Controllers;

/// <summary>
/// Weather Controller for Serving Weather Data
/// </summary>
[Route("api/[controller]")]
[ApiController]
public sealed class WeatherController : ControllerBase
{
    private readonly IWeatherApi _weatherApi;

    public WeatherController(IWeatherApi weatherApi)
    {
        _weatherApi = weatherApi;
    }

    /// <summary>
    /// Get Weather Data for a City
    /// </summary>
    /// <param name="city"></param>
    /// <param name="apiKey"></param>
    /// <returns>Weather Data for City Specified</returns>
    [HttpGet]
    public async Task<IActionResult> GetWeather(string city, string apiKey)
    {
        var response = await _weatherApi.GetWeatherAsync(new CityNameRequest
        {
            ApiKey = apiKey,
            CityName = city
        });

        if (response.IsSuccessStatusCode)
            return Ok(response.StatusCode);

        return StatusCode((int)response.StatusCode);
    }
}
