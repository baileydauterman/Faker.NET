using System;
using System.Globalization;
using Faker.NET.Interfaces;

namespace Faker.NET.Implementations;

public abstract class FakerLocaleInstance : IFakerLocaleInstance
{
    public virtual IFakerName Name { get; set; }

    public virtual IFakerCommerce Commerce { get; set; }

    public virtual IFakerLocation Location { get; set; }

    public virtual IFakerLorem Lorem { get; set; }

    public virtual IFakerUser User { get; set; }

    public virtual IFakerPhoneNumber PhoneNumber { get; set; }

    public virtual CultureInfo Culture { get; set; }
}
