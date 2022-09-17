using OpenWeather.SDK.Weather;
using Refit;

Console.WriteLine("Testing API Endpoints...");

var weatherApi = RestService.For<IWeatherApi>("");
var response = await weatherApi.GetWeatherAsync("London", "YOUR-KEY");

Console.WriteLine(response.StatusCode);