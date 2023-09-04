using Faker.NET.API;
using Faker.NET.Common;

namespace Faker.NET.Locales.ZH.Names
{
    public class Name : IFakerName
    {
        public string First => NameData.FirstNames.GetRandom();

        public string Last => NameData.LastNames.GetRandom();

        public string Full => $"{Last} {First}";

        public string Suffix => throw new NotImplementedException();

        public string Prefix => throw new NotImplementedException();

        public string Job => throw new NotImplementedException();

        public string Email => throw new NotImplementedException();

        //public static class Native
        //{
        //    public static string FirstName => firstName.Get();

        //    public static string LastName => lastName.Get();

        //    public static string FullName => $"{lastName.Get()} {firstName.Get()}";
        //}

        //public static class Translated
        //{
        //    public static string FirstName => firstName.Get(true);

        //    public static string LastName => lastName.Get(true);

        //    public static string FullName => $"{lastName.Get(true)} {firstName.Get(true)}";
        //}

        //private static LastName lastName = new();
        //private static FirstName firstName = new();
    }
}
