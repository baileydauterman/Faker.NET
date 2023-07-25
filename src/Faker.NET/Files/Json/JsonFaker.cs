using System.Text.Json;

namespace Faker.NET.Files.Json
{
	public class JsonFaker
	{
        public JsonFaker(bool indentation = false)
        {
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                WriteIndented = indentation
            };
        }

        public JsonFaker(string outputFile)
        {
            BaseStream = File.Open(outputFile, new FileStreamOptions
            {
                Mode = FileMode.OpenOrCreate,
                Access = FileAccess.ReadWrite,
            });
        }

        public JsonFaker(Stream stream)
        {
            if (!stream.CanWrite)
            {
                throw new Exception("Unable to write to stream");
            }

            BaseStream = stream;
        }

        public static string FromObject<T>(Func<T> processingFunc, JsonSerializerOptions options = null)
        {
            return JsonSerializer.Serialize(processingFunc(), options);
        }

        public JsonFaker AddField<T>(Func<object> processingFunc, int iterations = 1)
        {
            if (_processingDict.ContainsKey(typeof(T)))
            {
                throw new ArgumentException($"Dictionary already contains type: {typeof(T)}");
            }

            _processingDict.Add(typeof(T), (iterations, processingFunc));

            return this;
        }

        public string CreateJsonString()
		{
            var nodes = new List<System.Text.Json.Nodes.JsonNode>();

            foreach ((var key, var value) in _processingDict)
            {
                nodes.Add(JsonSerializer.SerializeToNode(value.Func()));
            }

            return JsonSerializer.Serialize(nodes, options: _jsonSerializerOptions);
		}

        public Stream BaseStream { get; }

        private readonly JsonSerializerOptions _jsonSerializerOptions;

        private Dictionary<Type, (int Iterations, Func<object>Func)> _processingDict = new();
	}
}

