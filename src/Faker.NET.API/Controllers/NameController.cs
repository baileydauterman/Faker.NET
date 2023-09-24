using Microsoft.AspNetCore.Mvc;

namespace Faker.NET.API.Controllers
{
	public class NameController : ControllerBase
	{
		[HttpGet("/name")]
		public IFakerName GetFakerName(string locale = "en")
		{
			Faker.SetLocale(locale);
			return Faker.Name;
		}

		[HttpGet("/name/first")]
		public IEnumerable<string> GetFirstName(string locale = "en", int count = 100)
		{
			Faker.SetLocale(locale);

			while (count-- != 0)
			{
				yield return Faker.Name.First;
			}
		}

        [HttpGet("/name/last")]
        public IEnumerable<string> GetLastName(string locale = "en", int count = 100)
        {
            Faker.SetLocale(locale);

            while (count-- != 0)
            {
                yield return Faker.Name.Last;
            }
        }

        [HttpGet("/name/full")]
        public IEnumerable<string> GetFullName(string locale = "en", int count = 100)
        {
            Faker.SetLocale(locale);

            while (count-- != 0)
            {
                yield return Faker.Name.Full;
            }
        }

        [HttpGet("/name/email")]
        public IEnumerable<string> GetEmail(string locale = "en", int count = 100)
        {
            Faker.SetLocale(locale);

            while (count-- != 0)
            {
                yield return Faker.Name.Email;
            }
        }
    }
}

