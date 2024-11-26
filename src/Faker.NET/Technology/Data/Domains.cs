using Faker.NET.Common.Exceptions;
namespace Faker.NET.Technology.Data;

public class Domains
{
    public static string[] GetLocaleDomains(FakerLocale locale)
    {
        var domains = locale switch
        {
            FakerLocale.English => _enDomains,
            _ => null
        };

        if (domains is null)
        {
            ThrowHelper.FakerLocaleNotImplementedException(locale, nameof(GetLocaleDomains));
        }

        return domains;
    }

    private static readonly string[] _enDomains = 
    {
        ".com",
        ".org",
        ".net",
        ".edu",
    };
}
