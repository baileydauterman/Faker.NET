namespace Faker.NET.API
{
    public interface IFakerLorem
    {
        string GetText(int count);
        
        string GetText(int min, int max);
    }
}
