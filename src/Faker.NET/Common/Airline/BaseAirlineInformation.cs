using System.Text.Json.Serialization;

namespace Faker.NET.Common.Airline;

public class BaseAirlineInformation
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Internation Air Transport Association (IATA) is a trade association representing airlines, focusing on commercial aspects like ticketing and baggage handling
    /// </summary>
    [JsonPropertyName("iataCode")]
    public string IataCode { get; set; } = string.Empty;

    /// <summary>
    /// International Civil Aviation Organization (ICAO) is a United Nations agency that sets international standards and regulations for aviation safety, navigation, and infrastructure.
    /// </summary>
    [JsonPropertyName("icaoCode")]
    public string IcaoCode { get; set; } = string.Empty;


    [JsonPropertyName("callsign")]
    public string Callsign { get; set; } = string.Empty;

    public override string ToString()
    {
        return Name;
    }
}
