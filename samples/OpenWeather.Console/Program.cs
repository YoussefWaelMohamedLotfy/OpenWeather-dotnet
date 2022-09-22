using OpenWeather.SDK.Geocoding;
using OpenWeather.SDK.Weather;
using Refit;

Console.WriteLine("Testing API Endpoints...");

var weatherApi = RestService.For<IWeatherApi>("https://api.openweathermap.org/data/2.5");
var weatherResponse = await weatherApi.GetWeatherAsync(new CityNameRequest()
{
    ApiKey = "6e2cf622ef8f02a604c95267d04473e3",
    CityName = "London"
});

Console.WriteLine($"Weather API Response Code: {weatherResponse.StatusCode}");

var geocodingApi = RestService.For<IGeocodingApi>("https://api.openweathermap.org/geo/1.0");
var geocodingResponse = await geocodingApi.GetCityCoordinatesAsync("London", "6e2cf622ef8f02a604c95267d04473e3", 1);

Console.WriteLine($"Geocoding API Response Code: {geocodingResponse.StatusCode}");
