using System.Text.Json.Serialization;
using Faker.NET.Data.Converters;

namespace Faker.NET.Location;

public class LocationState
{
    public LocationState()
    {

    }

    public LocationState(string abbreviation, string name, IEnumerable<int> zipCodes)
    {
        Abbreviation = abbreviation;
        Name = name;
        ZipCodes = zipCodes.ToArray();
    }

    public string Abbreviation { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    [JsonConverter(typeof(IntArrayConverter))]
    public IReadOnlyCollection<int> ZipCodes { get; set; } = Array.Empty<int>();
}
