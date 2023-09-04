using System;
using System.Globalization;

namespace Faker.NET.Common
{
	internal class FakerInstanceNotImplementedException : Exception
	{
		public FakerInstanceNotImplementedException(string methodName)
			: base($"{methodName} has not been implemented for {Faker.Culture.TwoLetterISOLanguageName}")
		{
		}
	}
}

