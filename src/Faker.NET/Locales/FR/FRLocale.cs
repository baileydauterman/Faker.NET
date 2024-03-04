using Faker.NET.Common;
using Faker.NET.Interfaces;
using Faker.NET.Locales.FR.Data;
using System.Globalization;

namespace Faker.NET.Locales.FR
{
    internal class FRLocale : IFakerInstance
    {
        public FRLocale()
        {
            Computer = new Computer();
            Name = new Name();
        }

        public IFakerComputer Computer { get; }

        public IFakerName Name { get; }

        public IFakerLocation Location => throw new NotImplementedException();

        public IFakerLorem Lorem => throw new NotImplementedException();

        public IFakerUser User => throw new NotImplementedException();

        public IFakerPhoneNumber PhoneNumber => throw new NotImplementedException();

        public CultureInfo Culture { get; } = CultureInfo.GetCultureInfo("fr");
    }

    internal class Name : IFakerName
    {
        public string First => NameData.FirstNames.GetRandom();

        public string Last => NameData.LastNames.GetRandom();

        public string Full => $"{First} {Last}";

        public string Suffix => throw new NotImplementedException();

        public string Prefix => throw new NotImplementedException();

        public string Job => throw new NotImplementedException();

        public string Email => throw new NotImplementedException();
    }
}
