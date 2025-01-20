using System.Reflection;
using System.Text.Json;

namespace Faker.NET.Data;

public class ResourceRetriever
{
    public ResourceRetriever()
    {
        _availableResources = Assembly.GetExecutingAssembly().GetManifestResourceNames() ?? Array.Empty<string>();
    }

    public ResourceRetriever(string locale, string module)
        : this()
    {
        _locale = locale;
        _module = module;
    }

    public Lazy<T> LazyGet<T>(string name)
    {
        return new Lazy<T>(() => Get<T>(_locale, _module, name));
    }

    public Lazy<T> LazyGet<T>(string locale, string module, string name)
        => new Lazy<T>(() => Get<T>(locale, module, name));

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

    public Lazy<IReadOnlyCollection<T>> LazyGetAsArray<T>(string name)
    {
        return new Lazy<IReadOnlyCollection<T>>(() => GetAsArray<T>(_locale, _module, name));
    }

    public Lazy<IReadOnlyCollection<T>> LazyGetAsArray<T>(string locale, string module, string name)
        => new Lazy<IReadOnlyCollection<T>>(() => GetAsArray<T>(locale, module, name));

    public IReadOnlyCollection<T> GetAsArray<T>(string locale, string module, string name)
    {
        return Get<List<T>>(locale, module, name) ?? new List<T>();
    }

    public Lazy<Dictionary<T, U>> LazyGet<T, U>(string name) where T : notnull
    {
        return new Lazy<Dictionary<T, U>>(() => Get<T, U>(_locale, _module, name));
    }

    public Lazy<Dictionary<T, U>> LazyGet<T, U>(string locale, string module, string name) where T : notnull
        => new Lazy<Dictionary<T, U>>(() => Get<T, U>(locale, module, name));

    public Dictionary<T, U> Get<T, U>(string locale, string module, string name) where T : notnull
    {
        return Get<Dictionary<T, U>>(locale, module, name) ?? new Dictionary<T, U>();
    }

    private readonly string[] _availableResources;
    private readonly string _locale = string.Empty;
    private readonly string _module = string.Empty;
}
