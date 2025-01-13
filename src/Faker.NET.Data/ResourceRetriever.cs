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

        public T? Get<T>(string locale, string module, string name)
        {
            name = $"Faker.NET.Data.{locale.ToUpper()}.{module}.{name}.json";
            if (_availableResources.Contains(name))
            {
                using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
                var deserialized = stream is null ? default : JsonSerializer.Deserialize<T>(stream);
                return deserialized;
            }

            return default;
        }

        public IReadOnlyCollection<T> GetAsArray<T>(string locale, string module, string name)
        {
            return Get<List<T>>(locale, module, name) ?? new List<T>();
        }

        private readonly string[] _availableResources;
    }
}
