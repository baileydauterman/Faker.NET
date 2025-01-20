namespace Faker.NET.Data.Converters
{
    public class Range
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public int[] ToArray()
        {
            if (Min > Max)
            {
                throw new ArgumentException($"Start ({Min}) cannot be larger than ending number ({Max})");
            }
            var retVal = new int[Max - Min + 1];

            for (var i = 0; i + Min <= Max; i++)
            {
                retVal[i] = Min + i;
            }

            return retVal;
        }
    }
}
