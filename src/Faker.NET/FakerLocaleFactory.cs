using Faker.NET.Common.Exceptions;
using Faker.NET.Interfaces;
using Faker.NET.Locales.AR;
using Faker.NET.Locales.DE;
using Faker.NET.Locales.EN;
using Faker.NET.Locales.FR;
using Faker.NET.Locales.RU;
using Faker.NET.Locales.ZH;
using System.Globalization;

namespace Faker.NET
{
    public static class FakerLocaleFactory
    {
        public static IFakerLocaleInstance Create(FakerLocale locale)
        {
            IFakerLocaleInstance faker = locale switch
            {
                FakerLocale.Arabic => new ARLocale(),
                FakerLocale.English => new ENLocale(),
                FakerLocale.German => new DELocale(),
                FakerLocale.French => new FRLocale(),
                FakerLocale.Russian => new RULocale(),
                FakerLocale.Mandarin => new ZHLocale(),
                FakerLocale.Unknown => new NoOpFakerInstance(),
                _ => new NoOpFakerInstance(),
            };

            if (faker is NoOpFakerInstance)
            {
                ThrowHelper.FakerLocaleNotImplementedException(locale, nameof(Create));
            }

            return faker;
        }

        public static FakerLocale GetLocale(CultureInfo culture)
        {
            FakerLocale locale = culture.TwoLetterISOLanguageName switch
            {
                "ar" => FakerLocale.Arabic,
                "de" => FakerLocale.German,
                "en" => FakerLocale.English,
                "fr" => FakerLocale.French,
                "ru" => FakerLocale.Russian,
                "zh" => FakerLocale.Mandarin,
                _ => FakerLocale.Unknown,
            };

            if (locale is FakerLocale.Unknown)
            {
                ThrowHelper.FakerInstanceNotImplementedException(culture.TwoLetterISOLanguageName);
            }

            return locale;
        }
    }
}
