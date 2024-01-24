using Faker.NET.Common;
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
        public static IFakerInstance Create(FakerLocale locale)
        {
            return locale switch
            {
                FakerLocale.Arabic => new ARLocale(),
                FakerLocale.English => new ENLocale(),
                FakerLocale.German => new DELocale(),
                FakerLocale.French => new FRLocale(),
                FakerLocale.Russian => new RULocale(),
                FakerLocale.Mandarin => new ZHLocale(),
                _ => throw new FakerInstanceNotImplementedException(locale.ToString()),
            };
        }

        public static FakerLocale GetLocale(CultureInfo culture)
        {
            return culture.TwoLetterISOLanguageName switch
            {
                "ar" => FakerLocale.Arabic,
                "de" => FakerLocale.German,
                "en" => FakerLocale.English,
                "fr" => FakerLocale.French,
                "ru" => FakerLocale.Russian,
                "zh" => FakerLocale.Mandarin,
                _ => throw new FakerInstanceNotImplementedException(culture.TwoLetterISOLanguageName),
            };
        }
    }
}
