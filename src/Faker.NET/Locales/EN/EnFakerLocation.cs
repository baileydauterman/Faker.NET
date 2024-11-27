using Faker.NET.Common;
using Faker.NET.Extensions;
using Faker.NET.Interfaces;
using Faker.NET.Locales.EN.Data;

namespace Faker.NET.Locales.EN;

internal class EnFakerLocation : IFakerLocation
{
    public string City => LocationData.Cities.GetRandom();

    public string State => LocationData.States.GetRandom();

    public string StateAbbreviation => LocationData.StatesAbbreviation.GetRandom();

    public string BuildingNumber => Faker.Randomizer.Next(1, 1000).ToString();

    public string Address => $"{BuildingNumber} {Street} {City}, {StateAbbreviation} {PostalCode}";

    public string PostalCode => _postalCodeFormat.ToRandomString();

    public string PostalCodeAlternate => _postalCodeAltFormat.ToRandomString();

    public string Street => LocationData.StreetNames.GetRandom();

    public const string _postalCodeFormat = "#####";
    public const string _postalCodeAltFormat = "#####-####";
}
