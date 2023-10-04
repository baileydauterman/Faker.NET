using Faker.NET.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Faker.NET.API.Controllers
{
    public class LoremController : ControllerBase
    {
        [HttpGet("lorem/exact")]
        public string GetLoremExact(string locale = "en", int exactNum = 100)
        {
            if (FakerService.TryGetInstance(locale, out var instance))
            {
                return instance.Lorem.GetText(exactNum);
            }

            return string.Empty;
        }

        [HttpGet("lorem")]
        public string GetLorem(string locale = "en", int min = 1, int max = 100)
        {
            if (FakerService.TryGetInstance(locale, out var instance))
            {
                return instance.Lorem.GetText(min, max);
            }

            return string.Empty;
        }
    }
}

