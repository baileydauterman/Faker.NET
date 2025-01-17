using System.Reflection;
using System.Text.Json;

namespace Faker.NET.Data
{
    public class ResourceRetriever
    {
        public ResourceRetriever()
        {
            _availableResources = Assembly.GetExecutingAssembly().GetManifestResourceNames() ?? Array.Empty<string>();
        }

        public T Get<T>(string locale, string module, string name)
        {
            name = $"Faker.NET.Data.{locale.ToUpper()}.{module}.{name}.json";
            if (_availableResources.Contains(name))
            {
                using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
                var deserialized = stream is null ? default : JsonSerializer.Deserialize<T>(stream, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                });
                return deserialized ?? Activator.CreateInstance<T>();
            }

            return Activator.CreateInstance<T>();
        }

        public IReadOnlyCollection<T> GetAsArray<T>(string locale, string module, string name)
        {
            return Get<List<T>>(locale, module, name) ?? new List<T>();
        }

        public Dictionary<T, U> Get<T, U>(string locale, string module, string name) where T : notnull
        {
            return Get<Dictionary<T, U>>(locale, module, name) ?? new Dictionary<T, U>();
        }

        private readonly string[] _availableResources;
    }
}
