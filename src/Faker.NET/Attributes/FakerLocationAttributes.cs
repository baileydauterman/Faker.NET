namespace Faker.NET.Attributes;

public class FakerLocationStreetAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Location.Street();
}

public class FakerLocationCityAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Location.City();
}

public class FakerLocationStateAttribute : FakerAttribute
{
    public bool Abbreviated = false;
    public override object GetPropertyValue()
    {
        return Faker.Location.State(Abbreviated);
    }
}

public class FakerLocationBuildingNumberAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Location.BuildingNumber();
}

public class FakerLocationAddressAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Location.StreetAddress();
}

public class FakerLocationPostalCodeAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Location.ZipCode();
}