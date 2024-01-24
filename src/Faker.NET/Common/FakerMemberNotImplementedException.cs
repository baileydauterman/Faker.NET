namespace Faker.NET.Common
{
    internal class FakerMemberNotImplementedException : Exception
    {
        public FakerMemberNotImplementedException(FakerLocale locale, string methodName)
            : base($"{methodName} is not yet implemented for {locale} locale in Faker.NET. Feel free to contribute at:\n\t https://github.com/baileydauterman/Faker.NET")
        {
        }
    }
}
