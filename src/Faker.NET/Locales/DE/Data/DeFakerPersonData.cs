﻿using Faker.NET.Common;
using Faker.NET.Common.Person;
using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Locales.DE.Data
{
    internal class DeFakerPersonData : IFakerPersonDefinition
    {
        public string[] BioPart => throw new NotImplementedException();

        public Func<IFakerPersonDefinition, string>[] BioPattern => throw new NotImplementedException();

        public string[] BioSupporter => throw new NotImplementedException();

        public SexSpecificValues<string> FirstName => throw new NotImplementedException();

        public string[] Gender => throw new NotImplementedException();

        public string[] JobArea => throw new NotImplementedException();

        public string[] JobDescriptor => throw new NotImplementedException();

        public Func<string>[] JobTitlePattern => throw new NotImplementedException();

        public string[] JobType => throw new NotImplementedException();

        public SexSpecificValues<string> LastName => throw new NotImplementedException();

        public WeightedList<Func<IFakerPersonDefinition, Sex, string>> LastNamePattern => throw new NotImplementedException();

        public SexSpecificValues<string> MiddleName => throw new NotImplementedException();

        public WeightedList<Func<string>> Name => throw new NotImplementedException();

        public SexSpecificValues<string> Prefix => throw new NotImplementedException();

        public string[] Suffix => throw new NotImplementedException();

        public string[] ZodiacSign => throw new NotImplementedException();
    }
}
