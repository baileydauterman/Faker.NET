namespace Faker.NET.Extensions
{
    internal static class DoubleExtensions
    {
        public static double SetPrecision(this double d, int precision)
        {
            return Math.Round(d, precision);
        }
    }
}
