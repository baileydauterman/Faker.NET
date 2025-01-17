using System.Globalization;
using Faker.NET.Interfaces;
using Faker.NET.Interfaces.Modules;
using Faker.NET.Modules.Interfaces;

namespace Faker.NET.Implementations.Modules;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
public abstract class FakerLocaleInstance : IFakerLocaleInstance
{
    public FakerLocaleInstance()
    {
    }

    public FakerLocaleInstance(string twoLetterIsoCultureCode)
    {
        Culture = CultureInfo.GetCultureInfo(twoLetterIsoCultureCode);

        Date = new FakerDate();
        Internet = new FakerInternet();
        Lorem = new FakerLorem();
        Person = new FakerPerson();
        PhoneNumber = new FakerPhone();
    }

    public virtual IFakerCommerce Commerce { get; set; }

    public virtual IFakerLocation Location { get; set; }

    public virtual IFakerLorem Lorem { get; set; }

    public virtual IFakerPhone PhoneNumber { get; set; }

    public virtual CultureInfo Culture { get; set; }

    public virtual IFakerWord Word { get; set; }

    public virtual IFakerDate Date { get; set; }

    public virtual IFakerInternet Internet { get; set; }

    public virtual IFakerAirline Airline { get; set; }

    public virtual IFakerPerson Person { get; set; }

    public virtual IFakerColor Color { get; set; } = new FakerColor();
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
