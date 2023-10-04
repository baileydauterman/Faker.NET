using Faker.NET.API;
using Faker.NET.Common;
using Faker.NET.Locales.RU.Data;

namespace Faker.NET.Locales.RU
{
    public class Name : IFakerName
    {
        public string First => NameData.FirstNames.GetRandom();

        public string Last => NameData.LastNames.GetRandom();

        public string Full => $"{First} {Last}";

        public string Suffix => throw new NotImplementedException();

        public string Prefix => throw new NotImplementedException();

        public string Job => $"{NameData.TitleLevel.GetRandom()} {NameData.TitleDescriptor.GetRandom()} {NameData.TitleJob.GetRandom()}";

        public string Email => EmailHelper.Generate(First, Last);

        //public static class Native
        //{
        //    public static string FirstName => firstName.Get();

        //    public static string MiddleName => middleName.Get();

        //    public static string LastName => lastName.Get();

        //    public static string FullName => $"{firstName.Get()} {lastName.Get()}";

        //    public static string JobTitle => title.Get(false);
        //}

        //public static class Translated
        //{
        //    public static string FirstName => firstName.Get(true);

        //    public static string MiddleName => middleName.Get(true);

        //    public static string LastName => lastName.Get(true);

        //    public static string FullName => $"{firstName.Get(true)} {lastName.Get(true)}";

        //    public static string JobTitle => title.Get(true);
        //}

        //private static readonly FirstName firstName = new();
        //private static readonly MiddleName middleName = new();
        //private static readonly LastName lastName = new();
        //private static readonly Title title = new();
    }
}
