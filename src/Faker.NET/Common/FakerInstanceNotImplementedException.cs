namespace Faker.NET.Common
{
    public class FakerInstanceNotImplementedException : Exception
    {
        public FakerInstanceNotImplementedException(string methodName)
            : base($"{methodName} is not yet implemented by Faker.NET. Feel free to contribute at:\n\t https://github.com/baileydauterman/Faker.NET")
        {
        }
    }
}

