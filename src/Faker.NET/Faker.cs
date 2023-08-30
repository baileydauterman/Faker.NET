using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.Locales;
using Faker.NET.Locales.EN;
using System.Globalization;

namespace Faker.NET
{
    /// <summary>
    /// Decorator to handle Locales and calls to base classes
    /// </summary>
    public class Faker
    {
        public static void SetLocale(string locale)
        {
            Culture = CultureInfo.GetCultureInfo(locale);
            SetFakerInstance();
        }

        public static void SetLocale(CultureInfo cultureInfo)
        {
            Culture = cultureInfo;
            FakerInstance = SetFakerInstance();
        }

        private static IFakerLocale SetFakerInstance()
        {
            switch (Culture.TwoLetterISOLanguageName)
            {
                case "en":
                    return new ENLocale();

                default:
                    throw new NotSupportedException($"{Culture.TwoLetterISOLanguageName} is not yet supported by Faker.NET. Feel free to contribute at:\n\t" +
                        $"https://github.com/baileydauterman/Faker.NET");
            }
        }

        public static CultureInfo Culture { get; private set; } = CultureInfo.CurrentCulture;

        public static IFakerName Name => FakerInstance.Name;

        public static IFakerUser User => FakerInstance.User;

        public static IFakerLorem Lorem => FakerInstance.Lorem;
        
        public static Randomizer Randomizer = new Randomizer();

        private static IFakerLocale FakerInstance { get; set; } = SetFakerInstance();
    }
}
