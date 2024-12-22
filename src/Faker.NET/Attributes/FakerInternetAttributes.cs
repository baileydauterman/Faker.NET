using System;

namespace Faker.NET.Attributes;


public class FakerInternetEmailAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.Email();
}

public class FakerInternetDisplayNameAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.DisplayName();
}

public class FakerDomainNameAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.DomainName();
}

public class FakerInternetSuffixAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.DomainSuffix();
}

public class FakerInternetDomainWordAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.DomainWord();
}

public class FakerInternetHttpMethodAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.HttpMethod();
}

public class FakerInternetHttpStatusCodeAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.HttpStatusCode();
}

public class FakerInternetIPv4Attribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.IPv4();
}

public class FakerInternetIPv6Attribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.IPv6();
}

public class FakerInternetJWTAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.JWT();
}

public class FakerInternetMacAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.Mac();
}

public class FakerInternetPasswordAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.Password();
}