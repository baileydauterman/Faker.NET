using Faker.NET.Common;

namespace Faker.NET.Custom
{
    /// <summary>
    /// Allows users to create their own custom data sets to create data off of.
    /// </summary>
    public class Custom : FakerText
    {
        public Custom(ICollection<string> data)
        {

        }

        public string Primary => base.Get();

        public string Secondary => base.Get(true);
    }
}
