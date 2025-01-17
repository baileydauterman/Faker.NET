using System.Text.Json.Serialization;
using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Implementations.Definitions
{
    internal class BaseFakerCommerceProductNameDefinition : IFakerCommerceProductNameDefinition
    {
        [JsonPropertyName("adjective")]
        public string[] Adjective { get; set; } = Array.Empty<string>();

        [JsonPropertyName("material")]
        public string[] Material { get; set; } = Array.Empty<string>();

        [JsonPropertyName("product")]
        public string[] Product { get; set; } = Array.Empty<string>();
    }
}
