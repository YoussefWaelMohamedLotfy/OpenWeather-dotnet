using Refit;

namespace OpenWeather.SDK.Geocoding;

public sealed class ZipCodeGeocodingRequest : OpenWeatherBase
{
    [AliasAs("zip")]
    public string? ZipCode { get; init; }
}
