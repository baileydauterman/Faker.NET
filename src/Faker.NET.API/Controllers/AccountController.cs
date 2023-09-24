using Faker.NET.Common.Objects;
using Microsoft.AspNetCore.Mvc;

namespace Faker.NET.API.Controllers
{
	public class AccountController : ControllerBase
    {
        [HttpGet("/get/account")]
        public IEnumerable<User> GetAccount(string locale = "en", int count = 100)
        {
            Faker.SetLocale(locale);

            while (count-- != 0)
            {
                yield return Faker.User.New;
            }
        }
    }
}

