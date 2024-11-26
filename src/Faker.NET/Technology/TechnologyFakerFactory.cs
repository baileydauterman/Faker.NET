using Faker.NET;
using Faker.NET.Common.Exceptions;
using Faker.NET.Interfaces;
using System.Globalization;

namespace Faker.NET.Technology;

public class TechnologyFakerFactory
{
    public static IFakerComputer GetComputerFaker(CultureInfo culture)
    {
        var locale = FakerLocaleFactory.GetLocale(culture);
        return GetComputerFaker(locale);
    }

    public static IFakerComputer GetComputerFaker(FakerLocale locale)
    {
        var domains = Data.Domains.GetLocaleDomains(locale);
        var faker = locale switch
        {
            FakerLocale.English => new Computer(domains),
            _ => null
        };

        if (faker is null)
        {
            ThrowHelper.FakerLocaleNotImplementedException(locale, nameof(GetComputerFaker));
        }

        return faker;
    }
}
