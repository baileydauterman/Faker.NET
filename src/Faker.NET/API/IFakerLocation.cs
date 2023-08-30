namespace Faker.NET.API
{
    public interface IFakerLocation
    {
        string City { get; }
        string State { get; }
        string StateAbbreviation { get; }
        string BuildingNumber { get; }
        string Address { get; }
        string ZipCode { get; }
        string LongZipCode { get; }
    }
}
