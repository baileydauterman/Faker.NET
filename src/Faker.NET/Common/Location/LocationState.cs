namespace Faker.NET.Location;

public class LocationState
{
    public LocationState(string abbreviation, string name, IEnumerable<int> zipCodes)
    {
        Abbreviation = abbreviation;
        Name = name;
        ZipCodes = zipCodes.ToArray();
    }

    public string Abbreviation { get; set; }

    public string Name { get; set; }

    public int[] ZipCodes { get; set; }
}
