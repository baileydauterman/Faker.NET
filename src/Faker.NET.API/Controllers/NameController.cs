using Faker.NET.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Faker.NET.API.Controllers
{
    public class NameController : ControllerBase
    {
        [HttpGet("/name")]
        public ObjectResult GetFakerName(string locale = "en")
        {
            return FakerService.GetInstanceFunc(locale, (instance) => instance.Name);
        }

        [HttpGet("/name/first")]
        public IEnumerable<string> GetFirstName(string locale = "en", int count = 100)
        {
            if (FakerService.TryGetInstance(locale, out var instance))
            {
                return FakerService.GetEnumerableValues(() => instance.Name.First, count);
            }
            else
            {
                return Enumerable.Empty<string>();
            }
        }

        [HttpGet("/name/last")]
        public IEnumerable<string> GetLastName(string locale = "en", int count = 100)
        {
            if (FakerService.TryGetInstance(locale, out var instance))
            {
                return FakerService.GetEnumerableValues(() => instance.Name.Last, count);
            }
            else
            {
                return Enumerable.Empty<string>();
            }
        }

        [HttpGet("/name/full")]
        public IEnumerable<string> GetFullName(string locale = "en", int count = 100)
        {
            if (FakerService.TryGetInstance(locale, out var instance))
            {
                return FakerService.GetEnumerableValues(() => instance.Name.Full, count);
            }
            else
            {
                return Enumerable.Empty<string>();
            }
        }

        [HttpGet("/name/email")]
        public IEnumerable<string> GetEmail(string locale = "en", int count = 100)
        {
            if (FakerService.TryGetInstance(locale, out var instance))
            {
                return FakerService.GetEnumerableValues(() => instance.Name.Email, count);
            }
            else
            {
                return Enumerable.Empty<string>();
            }
        }
    }
}

