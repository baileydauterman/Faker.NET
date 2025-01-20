namespace Faker.NET.Interfaces.Modules;

public interface IFakerNumber
{
    public long BigInt(long min = long.MinValue, long max = long.MaxValue);
    public string Binary(int min = int.MinValue, int max = int.MaxValue);
    public float Float(float min = float.MinValue, float max = float.MaxValue);
    public string Hex(int min = 0, int max = 15);
    public string Int(int min = int.MinValue, int max = int.MaxValue);
    public string Octal(int min = 0, int max = 7);
    public string RomanNumeral(int min = 0, int max = 3999);
}
