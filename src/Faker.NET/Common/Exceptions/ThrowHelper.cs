namespace Faker.NET.Common.Exceptions;

public static class ThrowHelper
{
    public static void NotImplementedException()
    {
        throw new NotImplementedException();
    }

    public static T NotImplementedException<T>(T type)
    {
        throw new NotImplementedException();
    }

    public static void FakerInstanceNotImplementedException(string methodName)
    {
        throw new FakerInstanceNotImplementedException(methodName);
    }

    public static T FakerInstanceNotImplementedException<T>(T instance, string methodName)
    {
        throw new FakerInstanceNotImplementedException(methodName);
    }

    public static void FakerMemberNotImplementedException(FakerLocale locale, string methodName)
    {
        throw new FakerMemberNotImplementedException(locale, methodName);
    }

    public static T FakerMemberNotImplementedException<T>(T type, FakerLocale locale, string methodName)
    {
        throw new FakerMemberNotImplementedException(locale, methodName);
    }

    public static void FakerLocaleNotImplementedException(FakerLocale locale, string methodName)
    {
        throw new FakerLocaleNotImplementedException(locale, methodName);
    }

    public static void FakerAttributeNotImplementedException(string attribute, string attributeClass)
    {
        throw new FakerAttributeNotImplementedException(attribute, attributeClass);
    }
}
