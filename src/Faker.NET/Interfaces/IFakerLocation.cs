﻿namespace Faker.NET.Interfaces
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

        string Latitude { get; }

        string Longitude { get; }
    }
}
