using System.Text.Json;
using System.Text.Json.Serialization;

namespace Faker.NET.Data.Converters;

public class IntArrayConverter : JsonConverter<IReadOnlyCollection<int>>
{
    public override IReadOnlyCollection<int> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.StartObject)
        {
            var range = JsonSerializer.Deserialize<Range>(ref reader, options)!;
            return range.ToArray();
        }
        else if (reader.TokenType == JsonTokenType.StartArray)
        {
            return JsonSerializer.Deserialize<int[]>(ref reader, options)!;
        }

        throw new JsonException($"Invalie start token type: {reader.TokenType}");
    }

    public override void Write(Utf8JsonWriter writer, IReadOnlyCollection<int> dictionary, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}

