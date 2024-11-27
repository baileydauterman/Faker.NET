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
            return Next(1, 10) > 5 ? Coin.Heads : Coin.Tails;
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
    }

    public enum Coin
    {
        Heads,
        Tails,
    }
}
