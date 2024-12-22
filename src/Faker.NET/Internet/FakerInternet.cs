using System;
using System.Net;
using Faker.NET.Extensions;
using Faker.NET.Interfaces;
using Faker.NET.Internet.Data;
using Faker.NET.Internet.Generators;

namespace Faker.NET.Internet;

public class FakerInternet : IFakerInternet
{
    public string DisplayName(string? first = null, string? middle = null, string? last = null)
    {
        return Username(first, middle, last);
    }

    public string DomainName()
    {
        return $"{DomainWord()}{DomainSuffix()}";
    }

    public string DomainSuffix()
    {
        return Domains.TopLevelDomains.GetRandom();
    }

    public string DomainWord()
    {
        throw new NotImplementedException();
    }

    public string Email(string? firstName = null, string? middleName = null, string? lastName = null, string? provider = null, bool allowSpecialCharacters = true)
    {
        var userName = Username(firstName, middleName, lastName);
        provider ??= DomainName();
        return $"{userName}@{provider}";
    }

    public string Emoji()
    {
        throw new NotImplementedException();
    }

    public string HttpMethod()
    {
        return Http.Methods.GetRandom();
    }

    public string HttpStatusCode()
    {
        return Http.StatusCodes.GetRandom();
    }

    public string IPv4(string? cidrBlock, NetworkTypes network = NetworkTypes.Any)
    {
        return _ipv4Generator.Value.Generate(cidrBlock, network);
    }

    public string IPv6()
    {
        // get 16 random bytes and convert them into an IP address
        return new IPAddress(Faker.Randomizer.NextBytes(16)).ToString();
    }

    public string JWT()
    {
        throw new NotImplementedException();
    }

    public string Mac(string? separator)
    {
        var arr = new string[6];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = _hexGenerator.Value.Generate();
        }

        return string.Join(separator, arr);
    }

    public string Password(int length = 15, bool memorable = false, string prefix = "")
    {
        var password = _passwordGenerator.Value.Generate(length);
        return $"{prefix}{password}";
    }

    public string Port()
    {
        return Faker.Randomizer.Next(0, 65535).ToString();
    }

    public string Protocol()
    {
        throw new NotImplementedException();
    }

    public string Rgb(int? redBase, int? greenBase, int? blueBase)
    {
        redBase ??= Faker.Randomizer.Next(0, 255);
        greenBase ??= Faker.Randomizer.Next(0, 255);
        blueBase ??= Faker.Randomizer.Next(0, 255);

        return $"({redBase}, {greenBase}, {blueBase})";
    }

    public string Url(bool appendSlash = false, string protocol = "https")
    {
        var slash = appendSlash ? "/" : "";
        return $"{protocol}://{DomainName()}{slash}";
    }

    public string UserAgent()
    {
        return UserAgents.Values.GetRandom();
    }

    public string Username(string? first, string? middle, string? last)
    {
        first ??= Faker.Name.First;
        middle ??= Faker.Name.First;
        last ??= Faker.Name.Last;

        var userName = Faker.Randomizer.Next(1, 5) switch
        {
            1 => $"{first}.{last}", // john.doe
            2 => $"{last}.{first}", // doe.john
            3 => $"{first[0]}{last}", //jdoe
            4 => $"{first}{last[0]}", // johnd
            5 => $"{first}.{middle[0]}.{last}", // john.e.doe
            _ => $"{first}{last}", // johndoe
        };

        return userName.ToLower();
    }

    private Lazy<PasswordGenerator> _passwordGenerator = new Lazy<PasswordGenerator>();
    private Lazy<IPv4Generator> _ipv4Generator = new Lazy<IPv4Generator>();
    private Lazy<HexGenerator> _hexGenerator = new Lazy<HexGenerator>();
}
