using System.Text.Json.Serialization;

namespace Faker.NET.Common.Location;

public class Direction
{
    public Direction(IReadOnlyCollection<string> cardinal, IReadOnlyCollection<string> cardinalAbbr, IReadOnlyCollection<string> ordinal, IReadOnlyCollection<string> ordinalAbbr)
    {
        Cardinal = cardinal;
        CardinalAbbr = cardinalAbbr;
        Ordinal = ordinal;
        OrdinalAbbr = ordinalAbbr;
    }

    [JsonPropertyName("cardinal")]
    public IReadOnlyCollection<string> Cardinal { get; set; }

    [JsonPropertyName("cardinalAbbreviated")]
    public IReadOnlyCollection<string> CardinalAbbr { get; set; }

    [JsonPropertyName("ordinal")]
    public IReadOnlyCollection<string> Ordinal { get; set; }

    [JsonPropertyName("ordinalAbbreviated")]
    public IReadOnlyCollection<string> OrdinalAbbr { get; set; }
}
