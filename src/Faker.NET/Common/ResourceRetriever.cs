using System.Reflection;
using System.Text.Json;

namespace Faker.NET.Common
{
    internal class ResourceRetriever
    {
        public ResourceRetriever()
        {
            _availableResources = Assembly.GetExecutingAssembly().GetManifestResourceNames() ?? Array.Empty<string>();
        }

        public IReadOnlyCollection<T> Get<T>(string name)
        {
            name = $"Faker.NET.Locales.{name}";
            if (_availableResources.Contains(name))
            {
                using var stream = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(name));
                var deserialized = stream is null ? null : JsonSerializer.Deserialize<List<T>>(stream.BaseStream);
                return deserialized ?? new List<T>();
            }

            return Array.Empty<T>();
        }

        private readonly string[] _availableResources;
    }
}
