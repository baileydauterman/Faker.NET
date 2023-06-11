using System;
using Faker.NET.Common;

namespace Faker.NET.Custom
{
	public class CustomNumber : FakerNumber
	{
		public CustomNumber()
		{
		}

		public CustomNumber(string format = null, string secondaryFormat = null)
		{
			Format = format;
			AltFormat = secondaryFormat;
		}
    }
}

