namespace Faker.NET.Common
{
    public class NumericRange<T>
    {
        public NumericRange(T min, T max)
        {
            Min = min;
            Max = max;
        }

        public T Min { get; set; }

        public T Max { get; set; }
    }
}
