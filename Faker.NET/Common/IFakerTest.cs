namespace Faker.NET.Common
{
    public interface IFakerText
    {
        public string Get();

        public List<string> Data { get; }
    }
}
