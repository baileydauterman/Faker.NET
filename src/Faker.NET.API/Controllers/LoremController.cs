using Microsoft.AspNetCore.Mvc;

namespace Faker.NET.API.Controllers
{
	public class LoremController : ControllerBase
	{
		[HttpGet("lorem/exact")]
		public string GetLoremExact(string locale = "en", int exactNum = 100)
		{
			Faker.SetLocale(locale);
			return Faker.Lorem.GetText(exactNum);
		}

		[HttpGet("lorem")]
		public string GetLorem(string locale = "en", int min = 1, int max = 100)
		{
			Faker.SetLocale(locale);
			return Faker.Lorem.GetText(min, max);
		}
	}
}

