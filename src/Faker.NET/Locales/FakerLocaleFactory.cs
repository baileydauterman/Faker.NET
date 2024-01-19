using Faker.NET.Common;
using Faker.NET.Interfaces;
using Faker.NET.Locales.AR;
using Faker.NET.Locales.DE;
using Faker.NET.Locales.EN;
using Faker.NET.Locales.FR;
using Faker.NET.Locales.RU;
using Faker.NET.Locales.ZH;
using System.Globalization;

namespace Faker.NET.Locales
{
    public static class FakerLocaleFactory
    {
        public static IFakerInstance Create(SupportedFakerLocales locale)
        {
            return locale switch
            {
                SupportedFakerLocales.Arabic => new ARLocale(),
                SupportedFakerLocales.English => new ENLocale(),
                SupportedFakerLocales.German => new DELocale(),
                SupportedFakerLocales.French => new FRLocale(),
                SupportedFakerLocales.Russian => new RULocale(),
                SupportedFakerLocales.Mandarin => new ZHLocale(),
                _ => throw new FakerInstanceNotImplementedException(locale.ToString()),
            };
        }

        public static SupportedFakerLocales GetLocale(CultureInfo culture)
        {
            return culture.TwoLetterISOLanguageName switch
            {
                "ar" => SupportedFakerLocales.Arabic,
                "de" => SupportedFakerLocales.German,
                "en" => SupportedFakerLocales.English,
                "fr" => SupportedFakerLocales.French,
                "ru" => SupportedFakerLocales.Russian,
                "zh" => SupportedFakerLocales.Mandarin,
                _ => throw new FakerInstanceNotImplementedException(culture.TwoLetterISOLanguageName),
            };
        }
    }
}
