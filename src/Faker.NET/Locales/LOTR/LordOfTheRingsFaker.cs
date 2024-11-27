using Faker.NET.Interfaces;
using System.Globalization;

namespace Faker.NET.Fantasy
{
    public class LordOfTheRingsFaker : IFakerLocaleInstance
    {
        public IFakerName Name { get; }

        public IFakerLocation Location { get; }

        public IFakerLorem Lorem { get; }

        public IFakerUser User { get; }

        public IFakerPhoneNumber PhoneNumber { get; }

        public CultureInfo Culture { get; }
    }
}