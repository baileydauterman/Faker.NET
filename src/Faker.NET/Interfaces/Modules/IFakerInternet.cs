using Faker.NET.Common;
using Faker.NET.Common.Internet;

namespace Faker.NET.Interfaces.Modules;

public interface IFakerInternet
{
    string DisplayName(string? first = null, string? middle = null, string? last = null);

    string DomainName();

    string DomainSuffix();

    string DomainWord();

    string Email(string? firstName = null, string? middleName = null, string? lastName = null, string? provider = null, bool allowSpecialCharacters = true);

    string Emoji(EmojiTypes? type = null);

    string HttpMethod();

    string HttpStatusCode();

    string IPv4(string? cidrBlock = null, NetworkTypes network = NetworkTypes.Any);

    string IPv6();

    string JWT();

    string Mac(string? separator = null);

    string Password(int length = 15, bool memorable = false, string prefix = "", StringCharacterTypes characterTypes = StringCharacterTypes.All);

    string Port();

    string Protocol();

    string Url(bool appendSlash = false, string protocol = "https");

    string UserAgent();

    string Username(string? first = null, string? middle = null, string? last = null);
}
