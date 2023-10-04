using Faker.NET.Common;
using Faker.NET.Locales;
using Microsoft.AspNetCore.Mvc;

namespace Faker.NET.API.Controllers
{
    public class NameController : ControllerBase
    {
        [HttpGet("/name")]
        public ObjectResult GetFakerName(string locale = "en")
        {
            return GetInstanceFunc(locale, (instance) => instance.Name);
        }

        [HttpGet("/name/first")]
        public IEnumerable<string> GetFirstName(string locale = "en", int count = 100)
        {
            if (TryGetInstance(locale, out var instance) && instance is not null)
            {
                return GetEnumerableValues(() => instance.Name.First, count);
            }
            else
            {
                return Enumerable.Empty<string>();
            }
        }

        [HttpGet("/name/last")]
        public IEnumerable<string> GetLastName(string locale = "en", int count = 100)
        {
            if (TryGetInstance(locale, out var instance) && instance is not null)
            {
                return GetEnumerableValues(() => instance.Name.Last, count);
            }
            else
            {
                return Enumerable.Empty<string>();
            }
        }

        [HttpGet("/name/full")]
        public IEnumerable<string> GetFullName(string locale = "en", int count = 100)
        {
            if (TryGetInstance(locale, out var instance) && instance is not null)
            {
                return GetEnumerableValues(() => instance.Name.Full, count);
            }
            else
            {
                return Enumerable.Empty<string>();
            }
        }

        [HttpGet("/name/email")]
        public IEnumerable<string> GetEmail(string locale = "en", int count = 100)
        {
            if (TryGetInstance(locale, out var instance) && instance is not null)
            {
                return GetEnumerableValues(() => instance.Name.Email, count);
            }
            else
            {
                return Enumerable.Empty<string>();
            }
        }

        private ObjectResult GetInstanceFunc<T>(string locale, Func<IFakerInstance, T> func)
        {
            try
            {
                var instance = Faker.GetInstance(locale);
                return Ok(func.Invoke(instance));
            }
            catch (FakerInstanceNotImplementedException e)
            {
                return Problem(e.Message);
            }
        }

        private bool TryGetInstance(string locale, out IFakerInstance? instance)
        {
            try
            {
                instance = Faker.GetInstance(locale);
                return true;
            }
            catch (FakerInstanceNotImplementedException e)
            {
                instance = null;
                return false;
            }
        }

        private IEnumerable<string> GetEnumerableValues(Func<string> stringFunc, int count)
        {
            while (count-- != 0)
            {
                yield return stringFunc.Invoke();
            }
        }
    }
}

