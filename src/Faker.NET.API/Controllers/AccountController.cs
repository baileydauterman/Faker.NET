using Faker.NET.API.Services;
using Faker.NET.Common.Objects;
using Microsoft.AspNetCore.Mvc;

namespace Faker.NET.API.Controllers
{
    public class AccountController : ControllerBase
    {
        [HttpGet("/get/account")]
        public IEnumerable<User> GetAccount(string locale = "en", int count = 100)
        {
            if (FakerService.TryGetInstance(locale, out var instance))
            {
                while (count-- != 0)
                {
                    yield return instance.User.New;
                }
            }
        }
    }
}

