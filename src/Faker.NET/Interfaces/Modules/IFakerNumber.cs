using Faker.NET.Common;

namespace Faker.NET.Interfaces.Modules
{
    public interface IFakerNumber
    {
        public long BigInt(long min = long.MinValue, long max = long.MaxValue);
        public long BigInt(NumericRange<long> range);
        public string Binary(int min = int.MinValue, int max = int.MaxValue);
        public string Binary(NumericRange<int> range);
        public float Float(float min = float.MinValue, float max = float.MaxValue);
        public float Float(NumericRange<float> range);
        public string Hex(int min = 0, int max = 15);
        public string Hex(NumericRange<int> range);
        public string Int(int min = int.MinValue, int max = int.MaxValue);
        public string Int(NumericRange<int> range);
        public string Octal(int min = 0, int max = 7);
        public string Octal(NumericRange<int> range);
        public string RomanNumeral(int min = 0, int max = 3999);
        public string RomanNumeral(NumericRange<int> range);
    }
}
