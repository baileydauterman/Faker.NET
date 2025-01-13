using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Implementations.Definitions
{
    internal class BaseFakerCommerceDefinition : IFakerCommerceDefinition
    {
        public IReadOnlyCollection<string> Department => lazyDepartment.Value;

        public IFakerCommerceProductNameDefinition ProductName => lazyProductName.Value;

        public IReadOnlyCollection<string> ProductDescription => lazyProductDescription.Value;

        internal Lazy<IReadOnlyCollection<string>> lazyDepartment = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Commerce", "departments"));
        internal Lazy<IReadOnlyCollection<string>> lazyProductDescription = new(() => Faker.ResourceRetriever.GetAsArray<string>(Faker.Culture.TwoLetterISOLanguageName, "Commerce", "product_description_patterns"));
        internal Lazy<IFakerCommerceProductNameDefinition> lazyProductName = new(() =>
        {
            return Faker.ResourceRetriever.Get<BaseFakerCommerceProductNameDefinition>(Faker.Culture.TwoLetterISOLanguageName, "Commerce", "product_names") ??
                   throw new NullReferenceException();
        });
    }
}
