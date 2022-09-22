using OpenWeather.SDK.Geocoding;
using OpenWeather.SDK.Weather;
using Refit;

Console.WriteLine("Testing API Endpoints...");

var apiKey = "Your OpenWeather API Key";

var weatherApi = RestService.For<IWeatherApi>("https://api.openweathermap.org/data/2.5");
var weatherResponse = await weatherApi.GetWeatherAsync(new CityNameRequest()
{
    ApiKey = apiKey,
    CityName = "London"
});

Console.WriteLine($"Weather API Response Code: {weatherResponse.StatusCode}");

var geocodingApi = RestService.For<IGeocodingApi>("https://api.openweathermap.org/geo/1.0");
var geocodingResponse = await geocodingApi.GetCityCoordinatesAsync(new()
{
    ApiKey = apiKey,
    CityName = "London",
    Limit = 1
});

Console.WriteLine($"Geocoding API Response Code: {geocodingResponse.StatusCode}");
