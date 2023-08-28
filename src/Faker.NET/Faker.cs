using Faker.NET.Locales;
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
            Culture = CultureInfo.CurrentCulture.EnglishName;
        }

        public FakerDecorator(string culture)
        {
            SetLocale(culture);
        }

        public FakerDecorator(CultureInfo cultureInfo)
        {
            Culture = cultureInfo.DisplayName;
        }

        public void SetLocale(string locale)
        {
            Culture = CultureInfo.GetCultureInfo(locale).DisplayName ?? CultureInfo.CurrentCulture.DisplayName;

        }

        public void SetLocale(CultureInfo cultureInfo)
        {
            Culture = cultureInfo.DisplayName;
        }

        private void SetFakerInstance()
        {
            switch (Culture)
            {
                
            }
        }

        public string Culture { get; private set; }

        public IFakerLocale FakerInstance { get; private set; }

    }
}
