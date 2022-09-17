using Microsoft.Extensions.DependencyInjection;
using OpenWeather.SDK.Geocoding;
using OpenWeather.SDK.Weather;
using Refit;

namespace OpenWeather.SDK;

/// <summary>
/// Extensions to the SDK
/// </summary>
public static class SdkExtensions
{
    /// <summary>
    /// Registers the OpenWeather API to the DI Container
    /// </summary>
    /// <param name="services">DI Container</param>
    /// <returns>A reference to the Service Collection for Chaining Calls</returns>
    public static IServiceCollection AddOpenWeather(this IServiceCollection services)
    {
        services.AddRefitClient<IWeatherApi>()
            .ConfigureHttpClient(client =>
            {
                client.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5");
            });

        services.AddRefitClient<IGeocodingApi>()
            .ConfigureHttpClient(client =>
            {
                client.BaseAddress = new Uri("https://api.openweathermap.org/geo/1.0");
            }); 

        return services;
    }
}
