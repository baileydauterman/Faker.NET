using Faker.NET.Locales;
using Faker.NET.Locales.EN;
using System.Globalization;

namespace Faker.NET
{
    /// <summary>
    /// Decorator to handle Locales and calls to base classes
    /// </summary>
    public class FakerDecorator
    {
        public FakerDecorator()
        {
            Culture = CultureInfo.CurrentCulture;
        }

        public FakerDecorator(string culture)
        {
            SetLocale(culture);
        }

        public FakerDecorator(CultureInfo cultureInfo)
        {
            Culture = cultureInfo;
        }

        public void SetLocale(string locale)
        {
            Culture = CultureInfo.GetCultureInfo(locale);
        }

        public void SetLocale(CultureInfo cultureInfo)
        {
            Culture = cultureInfo;
        }

        private void SetFakerInstance()
        {
            switch (Culture.TwoLetterISOLanguageName)
            {
                case "en":
                    FakerInstance = new ENLocale();
                    break;

                default:
                    throw new NotSupportedException($"{Culture.TwoLetterISOLanguageName} is not yet supported by Faker.NET. Feel free to contribute at:" +
                        $"https://github.com/baileydauterman/Faker.NET");
            }
        }

        public CultureInfo Culture { get; private set; }

        public IFakerLocale FakerInstance { get; private set; }

    }
}
