using Faker.NET.Common;
using Faker.NET.Common.Internet;

namespace Faker.NET.Attributes;


public class FakerInternetEmailAttribute : FakerAttribute
{
    public string? FirstName { get; set; } = null;
    public string? MiddleName { get; set; } = null;
    public string? LastName { get; set; } = null;
    public string? Provider { get; set; } = null;
    public bool AllowSpecialCharacters { get; set; } = true;
    public override object GetPropertyValue() => Faker.Internet.Email(FirstName, MiddleName, LastName, Provider, AllowSpecialCharacters);
}

public class FakerInternetDisplayNameAttribute : FakerAttribute
{
    public string? First { get; set; } = null;
    public string? Middle { get; set; } = null;
    public string? Last { get; set; } = null;
    public override object GetPropertyValue() => Faker.Internet.DisplayName(First, Middle, Last);
}

public class FakerInternetDomainNameAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.DomainName();
}

public class FakerInternetDomainWordAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.DomainWord();
}

public class FakerInternetDomainSuffixAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.DomainSuffix();
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
    public string? CidrBlock { get; set; } = null;

    public NetworkTypes NetworkType { get; set; } = NetworkTypes.Any;

    public override object GetPropertyValue() => Faker.Internet.IPv4(CidrBlock, NetworkType);
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
    public int Length { get; set; } = 15;

    public bool Memorable { get; set; } = false;

    public string Prefix { get; set; } = string.Empty;

    public StringCharacterTypes CharacterTypes { get; set; } = StringCharacterTypes.All;

    public override object GetPropertyValue() => Faker.Internet.Password(Length, Memorable, Prefix, CharacterTypes);
}

public class FakerInternetPortAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.Port();
}

public class FakerInternetProtocolAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.Protocol();
}

public class FakerInternetUrlAttribute : FakerAttribute
{
    public bool AppendSlash { get; set; } = false;

    public string Protocol { get; set; } = "https";

    public override object GetPropertyValue() => Faker.Internet.Url(AppendSlash, Protocol);
}

public class FakerInternetUserAgentAttribute : FakerAttribute
{
    public override object GetPropertyValue() => Faker.Internet.UserAgent();
}

public class FakerInternetUsernameAttribute : FakerAttribute
{
    public string? First { get; set; } = null;

    public string? Middle { get; set; } = null;

    public string? Last { get; set; } = null;

    public override object GetPropertyValue() => Faker.Internet.Username(First, Middle, Last);
}

public class FakerInternetEmojiAttribute : FakerAttribute
{
    public EmojiTypes? EmojiType { get; set; } = null;
    public override object GetPropertyValue() => Faker.Internet.Emoji(EmojiType);
}