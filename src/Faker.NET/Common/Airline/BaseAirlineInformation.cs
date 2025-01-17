using System.Text.Json.Serialization;

namespace Faker.NET.Common.Airline;

public class BaseAirlineInformation
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("iataCode")]
    public string IataCode { get; set; } = string.Empty;

    public override string ToString()
    {
        return Name;
    }
}
