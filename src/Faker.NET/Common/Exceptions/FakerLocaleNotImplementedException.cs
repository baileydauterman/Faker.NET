namespace Faker.NET.Common.Exceptions;

public class FakerLocaleNotImplementedException : Exception
{
    public FakerLocaleNotImplementedException(FakerLocale locale, string methodName)
        : base($"{locale} is not implemented for {methodName}")
    {
    }
}
