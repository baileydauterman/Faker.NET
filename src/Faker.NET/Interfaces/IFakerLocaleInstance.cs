﻿using System.Globalization;
using Faker.NET.Interfaces.Modules;
using Faker.NET.Modules.Interfaces;

namespace Faker.NET.Interfaces
{
    /// <summary>
    /// Instance that contains all faker instances related to an <see cref="FakerLocale"/>
    /// </summary>
    public interface IFakerLocaleInstance
    {
        IFakerAirline Airline { get; }

        IFakerColor Color { get; }

        IFakerCommerce Commerce { get; }

        IFakerDate Date { get; }

        IFakerInternet Internet { get; }

        IFakerLocation Location { get; }

        IFakerLorem Lorem { get; }

        IFakerPerson Person { get; }

        IFakerPhone PhoneNumber { get; }

        IFakerWord Word { get; }

        CultureInfo Culture { get; }
    }
}
