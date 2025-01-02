using System.Text;
using Faker.NET.Extensions;

namespace Faker.NET.Common
{
    public class FakerRandomizer : Random
    {
        public FakerRandomizer() : base()
        {
        }

        public FakerRandomizer(int seed) : base(seed)
        {
        }

        public Coin FlipCoin()
        {
            return NextDouble() > 0.5 ? Coin.Heads : Coin.Tails;
        }

        /// <summary>
        /// Creates a random byte array of given length
        /// </summary>
        /// <param name="length">Length of return value</param>
        /// <returns>Random byte array</returns>
        public byte[] NextBytes(int length)
        {
            var bytes = new byte[length];
            NextBytes(bytes);
            return bytes;
        }

        public byte NextByte(byte? low = null, byte? high = null)
        {
            low ??= byte.MinValue;
            high ??= byte.MaxValue;

            return (byte)Next(low.Value, high.Value);
        }

        public double NextDouble(int min, int max)
        {
            var integral = (double)this.Next(min, max);
            var dec = this.NextDouble();

            // subtract to make sure we stay under the max
            return integral > 0 ? integral - dec : dec + integral;
        }

        public double NextDouble(double min, double max)
        {
            return NextDouble() * (max - min) + min;
        }

        public char NextCharacter(int low, int high)
        {
            return (char)Next(low, high);
        }

        public double Radian()
        {
            return this.Next(1, 12) * Math.PI / 6;
        }

        public string String(int length, StringCharacterTypes settings = StringCharacterTypes.All)
        {
            if (settings == StringCharacterTypes.None)
            {
                return "";
            }

            var builder = new StringBuilder(length);
            var generators = AddGenerators(settings);
            var generatorKeys = generators.Keys.ToList();

            while (length > 0)
            {
                length--;
                var random = generatorKeys.GetRandom();
                var randChar = generators[random].Invoke();
                builder.Append(randChar);
            }

            return builder.ToString();
        }

        private Dictionary<StringCharacterTypes, Func<char>> AddGenerators(StringCharacterTypes settings)
        {
            var stringGenerators = new Dictionary<StringCharacterTypes, Func<char>>();
            if ((settings & StringCharacterTypes.LowerCase) == StringCharacterTypes.LowerCase)
            {
                stringGenerators.Add(StringCharacterTypes.LowerCase, () => NextCharacter(97, 122));
            }

            if ((settings & StringCharacterTypes.UpperCase) == StringCharacterTypes.UpperCase)
            {
                stringGenerators.Add(StringCharacterTypes.UpperCase, () => NextCharacter(65, 90));
            }

            if ((settings & StringCharacterTypes.Special) == StringCharacterTypes.Special)
            {
                stringGenerators.Add(StringCharacterTypes.Special, () => NextCharacter(33, 64));
            }

            if ((settings & StringCharacterTypes.Numbers) == StringCharacterTypes.Numbers)
            {
                stringGenerators.Add(StringCharacterTypes.Numbers, () => NextCharacter(48, 57));
            }

            return stringGenerators;
        }
    }

    public enum Coin
    {
        Heads,
        Tails,
    }
}
