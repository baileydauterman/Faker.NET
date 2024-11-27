namespace Faker.NET.Common.Exceptions
{
    public class FakerInstanceNotImplementedException : Exception
    {
        public FakerInstanceNotImplementedException(string methodName)
            : base($"{methodName} is not yet implemented by Faker.NET. Feel free to contribute at:\n\t https://github.com/baileydauterman/Faker.NET")
        {
        }
    }
}

