using Faker.NET.Interfaces;
using Faker.NET.Common;
using Faker.NET.Locales;
using Faker.NET.Locales.AR;
using Faker.NET.Locales.DE;
using Faker.NET.Locales.EN;
using Faker.NET.Locales.FR;
using Faker.NET.Locales.RU;
using Faker.NET.Locales.ZH;
using System.Globalization;

namespace Faker.NET
{
    /// <summary>
    /// Decorator to handle Locales and calls to base classes
    /// </summary>
    public class Faker
    {
        public static IFakerInstance GetInstance(SupportedFakerLocales locale)
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
            }; ;
        }

        public static IFakerInstance GetInstance(string locale)
        {
            var fakerLocale = GetLocale(locale);
            return GetInstance(fakerLocale);
        }

        public static IFakerInstance GetInstance(CultureInfo culture)
        {
            return GetInstance(culture);
        }

        public static void SetLocale(CultureInfo cultureInfo)
            => UpdateCultureAndFakerInstance(cultureInfo);

        public static void SetLocale(string locale)
            => UpdateCultureAndFakerInstance(CultureInfo.GetCultureInfo(locale));

        public static void SetLocale(SupportedFakerLocales locale)
            => UpdateCultureAndFakerInstance(CultureInfo.GetCultureInfo(locale.ToString()));

        public static void SetLocale(IFakerInstance locale)
            => SetFakerInstance(locale);

        public static void SetInstance(SupportedFakerLocales locale)
        {
            SetFakerInstance(locale);
        }

        public static void SetInstance(IFakerInstance faker)
        {
            FakerInstance = faker;
        }

        private static SupportedFakerLocales GetLocale(CultureInfo culture)
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

        private static SupportedFakerLocales GetLocale(string locale)
        {
            var cultureInfo = CultureInfo.GetCultureInfo(locale);
            return GetLocale(cultureInfo);
        }

        private static void UpdateCultureAndFakerInstance(CultureInfo culture)
        {
            var locale = GetLocale(culture);
            SetFakerInstance(locale);
        }

        private static void SetFakerInstance(SupportedFakerLocales locale)
        {
            FakerInstance = GetInstance(locale);
        }

        private static void SetFakerInstance(IFakerInstance locale)
        {
            FakerInstance = locale;
        }

        public static CultureInfo Culture => FakerInstance.Culture;

        public static IFakerComputer Computer => FakerInstance.Computer;

        public static IFakerName Name => FakerInstance.Name;

        public static IFakerUser User => FakerInstance.User;

        public static IFakerLorem Lorem => FakerInstance.Lorem;

        public static IFakerLocation Location => FakerInstance.Location;

        public static IFakerPhoneNumber Phone => FakerInstance.PhoneNumber;

        public static IFakerCustom Custom { get; set; }

        public static Randomizer Randomizer { get; private set; } = new Randomizer();

        public static IFakerInstance FakerInstance { get; private set; } = new ENLocale();
    }

    public enum SupportedFakerLocales
    {
        English,
        Arabic,
        French,
        Russian,
        Mandarin,
        German,
    }
}
