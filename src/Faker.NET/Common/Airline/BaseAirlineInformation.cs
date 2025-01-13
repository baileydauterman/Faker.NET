using System.Text.Json.Serialization;

namespace Faker.NET.Common.Airline;

public class BaseAirlineInformation
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("iataCode")]
    public string IataCode { get; set; }

    public override string ToString()
    {
        return Name;
    }
}
