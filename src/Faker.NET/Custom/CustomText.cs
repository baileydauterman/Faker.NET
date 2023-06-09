using Faker.NET.Common;

namespace Faker.NET.Custom
{
    /// <summary>
    /// Allows users to create their own custom data sets to create data off of.
    /// </summary>
    public class Custom : FakerText
    {
        public Custom(List<string> primaryData, List<string> secondaryData)
        {
            if (primaryData is not null)
            {
                Native = primaryData;
            }

            if (secondaryData is not null)
            {
                Translated = secondaryData;
            }
        }

        public string Primary => base.Get();

        public string Secondary => base.Get(true);
    }
}
