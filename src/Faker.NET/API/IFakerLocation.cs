namespace Faker.NET.API
{
    public interface IFakerLocation
    {
        string Street { get; }

        string City { get; }

        string State { get; }

        string StateAbbreviation { get; }

        string BuildingNumber { get; }

        string Address { get; }

        string PostalCode { get; }

        string PostalCodeAlternate { get; }
    }
}
