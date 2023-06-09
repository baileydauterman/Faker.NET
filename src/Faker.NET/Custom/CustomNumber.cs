using System;
using Faker.NET.Common;

namespace Faker.NET.Custom
{
	public class CustomNumber : FakerNumber
	{
		public CustomNumber(string format = null, string secondaryFormat = null)
		{
			Format = format;
			AltFormat = secondaryFormat;
		}

        public string Get(string customFormat)
        {
            return Convert(customFormat);
        }
    }
}

