using Faker.NET.Common;
using Faker.NET.Locales;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Faker.NET.API.Services
{
    internal class FakerService
    {
        public static bool TryGetInstance(string locale, out IFakerInstance instance)
        {
            try
            {
                instance = Faker.GetInstance(locale);
                return true;
            }
            catch
            {
                instance = new NoOpFakerInstance();
                return false;
            }
        }

        public static bool TryGetInstance<T>(string locale, Func<IFakerInstance, T> func, out ObjectResult result)
        {
            try
            {
                var instance = Faker.GetInstance(locale);
                result = new OkObjectResult(func.Invoke(instance));
                return true;
            }
            catch (Exception e)
            {
                result = new ObjectResult(e.Message)
                {
                    StatusCode = (int?)HttpStatusCode.InternalServerError
                };
                return false;
            }
        }

        public static IEnumerable<string> GetEnumerableValues(Func<string> stringFunc, int count)
        {
            while (count-- != 0)
            {
                yield return stringFunc.Invoke();
            }
        }

        public static ObjectResult GetInstanceFunc<T>(string locale, Func<IFakerInstance, T> func)
        {
            try
            {
                var instance = Faker.GetInstance(locale);
                return new OkObjectResult(func.Invoke(instance));
            }
            catch (FakerInstanceNotImplementedException e)
            {
                return new ObjectResult(e.Message)
                {
                    StatusCode = (int?)HttpStatusCode.NotImplemented,
                };
            }
        }
    }
}
