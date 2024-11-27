namespace Faker.NET.Attributes;

public class FakerLocationStreetAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Location.Street;
}

public class FakerLocationCityAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Location.City;
}

public class FakerLocationStateAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Location.State;
}

public class FakerLocationStateAbbreviationAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Location.StateAbbreviation;
}

public class FakerLocationBuildingNumberAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Location.BuildingNumber;
}

public class FakerLocationAddressAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Location.Address;
}

public class FakerLocationPostalCodeAttribute : FakerAttribute
{
    public bool UseAlternate {get;set;} = false;
    public override object GetPropertyValue() 
    {
        if (UseAlternate)
        {
            return Faker.Location.PostalCodeAlternate;
        }

        return Faker.Location.PostalCode;
    }
}