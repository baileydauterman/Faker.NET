using Faker.NET.Internet;

namespace Faker.NET.Interfaces;

public interface IFakerInternet
{
    string Rgb(int? redBase = null, int? greenBase = null, int? blueBase = null);

    string DisplayName(string? first = null, string? middle = null, string? last = null);

    string DomainName();

    string DomainSuffix();

    string DomainWord();

    string Email(string? firstName = null, string? middleName = null, string? lastName = null, string? provider = null, bool allowSpecialCharacters = true);

    string Emoji();

    string HttpMethod();

    string HttpStatusCode();

    string IPv4(string? cidrBlock = null, NetworkTypes network = NetworkTypes.Any);

    string IPv6();

    string JWT();

    string Mac(string? separator = null);

    string Password(int length = 15, bool memorable = false, string prefix = "");

    string Port();

    string Protocol();

    string Url(bool appendSlash = false, string protocol = "https");

    string UserAgent();

    string Username(string? first = null, string? middle = null, string? last = null);
}
