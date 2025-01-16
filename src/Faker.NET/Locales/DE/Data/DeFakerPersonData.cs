using Faker.NET.Common;
using Faker.NET.Common.Person;
using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Locales.DE.Data
{
    internal class DeFakerPersonData : IFakerPersonDefinition
    {
        public IReadOnlyCollection<string> BioPart => throw new NotImplementedException();

        public IReadOnlyCollection<string> BioPattern => throw new NotImplementedException();

        public IReadOnlyCollection<string> BioSupporter => throw new NotImplementedException();

        public SexSpecificValues<string> FirstName => throw new NotImplementedException();

        public IReadOnlyCollection<string> Gender => throw new NotImplementedException();

        public IReadOnlyCollection<string> JobArea => throw new NotImplementedException();

        public IReadOnlyCollection<string> JobDescriptor => throw new NotImplementedException();

        public IReadOnlyCollection<string> JobTitlePattern => throw new NotImplementedException();

        public IReadOnlyCollection<string> JobType => throw new NotImplementedException();

        public SexSpecificValues<string> LastName => throw new NotImplementedException();

        public WeightedList<string> LastNamePattern => throw new NotImplementedException();

        public SexSpecificValues<string> MiddleName => throw new NotImplementedException();

        public WeightedList<string> Name => throw new NotImplementedException();

        public SexSpecificValues<string> Prefix => throw new NotImplementedException();

        public IReadOnlyCollection<string> Suffix => throw new NotImplementedException();

        public IReadOnlyCollection<string> ZodiacSign => throw new NotImplementedException();
    }
}
