namespace Faker.NET.Attributes;

public class FakerNameFirstAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Name.First;
}

public class FakerNameLastAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Name.Last;
}

public class FakerNameFullAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Name.Full;
}

public class FakerNameSuffixAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Name.Suffix;
}

public class FakerNamePrefixAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Name.Prefix;
}

public class FakerNameJobAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Name.Job;
}

public class FakerNameEmailAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Name.Email;
}