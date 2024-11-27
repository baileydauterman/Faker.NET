using System;

namespace Faker.NET.Common.Exceptions;
    internal class FakerAttributeNotImplementedException : Exception
    {
        public FakerAttributeNotImplementedException(string attribute, string attributeClass)
            : base($"{attribute} is not implemented for {attributeClass}. Feel free to contribute at:\n\t https://github.com/baileydauterman/Faker.NET")
        {
        }
    }
