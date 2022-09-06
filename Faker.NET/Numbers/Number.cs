using Faker.NET.Common;

namespace Faker.NET.Numbers
{
    public class Number : IFakerNumber
    {
        public string NumberString
        {
            get => base.Get();
        }

        public string Format
        {
            get => _format;

            set
            {
                _format = value;
            }
        }

        public string _format = "###-###-####";
    }
}
