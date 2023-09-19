using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.Locales;
using Faker.NET.Locales.AR;
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
        public static void SetLocale(CultureInfo cultureInfo)
            => UpdateCultureAndFakerInstance(cultureInfo);

        public static void SetLocale(string locale)
            => UpdateCultureAndFakerInstance(CultureInfo.GetCultureInfo(locale));

        public static void SetLocale(SupportedLocales locale)
            => UpdateCultureAndFakerInstance(CultureInfo.GetCultureInfo(locale.ToString()));

        public static void SetLocale(IFakerLocale locale)
            => SetFakerInstance(locale);

        public static void SetInstance(SupportedLocales locale)
        {
            SetFakerInstance(locale);
        }

        public static void SetInstance(IFakerLocale faker)
        {
            FakerInstance = faker;
        }

        private static void UpdateCultureAndFakerInstance(CultureInfo culture)
        {
            var locale = culture.TwoLetterISOLanguageName switch
            {
                "ar" => SupportedLocales.Arabic,
                "en" => SupportedLocales.English,
                "fr" => SupportedLocales.French,
                "ru" => SupportedLocales.Russian,
                "zh" => SupportedLocales.Mandarin,
                _ => throw new FakerInstanceNotImplementedException(culture.TwoLetterISOLanguageName),
            };

            SetFakerInstance(locale);
        }

        private static void SetFakerInstance(SupportedLocales locale)
        {
            FakerInstance = locale switch
            {
                SupportedLocales.Arabic => new ARLocale(),
                SupportedLocales.English => new ENLocale(),
                SupportedLocales.French => new FRLocale(),
                SupportedLocales.Russian => new RULocale(),
                SupportedLocales.Mandarin => new ZHLocale(),
                _ => throw new FakerInstanceNotImplementedException(locale.ToString()),
            };
        }

        private static void SetFakerInstance(IFakerLocale locale)
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

        private static IFakerLocale FakerInstance { get; set; } = new ENLocale();
    }

    public enum SupportedLocales
    {
        English,
        Arabic,
        French,
        Russian,
        Mandarin,
    }
}
