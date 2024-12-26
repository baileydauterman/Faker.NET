using System;
using System.Formats.Asn1;

namespace Faker.NET.Dates;

public class DateTimeDifferenceBuilder
{
    public DateTimeDifferenceBuilder(DateTime start, DateTime end)
    {
        _startDt = start;
        _endDt = end;
        Year = Faker.Randomizer.Next(_startDt.Year, _endDt.Year);
    }

    public DateTime Build()
    {
        return new DateTime(Year, Month, Day, Hour, Minute, Second, Millisecond);
    }

    public DateTimeDifferenceBuilder SetMonths()
    {
        if (Year == _startDt.Year)
        {
            Month = Faker.Randomizer.Next(_startDt.Month, 12);
        }
        else if (Year == _endDt.Year)
        {
            Month = Faker.Randomizer.Next(1, _endDt.Month);
        }
        else
        {
            Month = Faker.Randomizer.Next(1, 13);
        }

        return this;
    }

    public DateTimeDifferenceBuilder SetDays()
    {
        var daysInMonth = DateTime.DaysInMonth(Year, Month);

        if (_startDt.Year == _endDt.Year && _startDt.Month == _endDt.Month)
        {
            Day = Faker.Randomizer.Next(_startDt.Day, _endDt.Day);
        }
        else if (Year == _startDt.Year && Month == _startDt.Month)
        {
            Day = Faker.Randomizer.Next(_startDt.Day, daysInMonth);
        }
        else if (Year == _endDt.Year && Month == _endDt.Month)
        {
            Day = Faker.Randomizer.Next(1, _endDt.Day);
        }
        else
        {
            Day = Faker.Randomizer.Next(1, daysInMonth);
        }

        return this;
    }

    public DateTimeDifferenceBuilder SetHours()
    {
        int startHours, endHours;
        if (Year == _startDt.Year && Month == _startDt.Month && Day == _startDt.Day)
        {
            startHours = _startDt.Hour;
            endHours = 24;
        }
        else if (Year == _endDt.Year && Month == _endDt.Month && Day == _endDt.Day)
        {
            startHours = 0;
            endHours = _endDt.Hour;
        }
        else
        {
            startHours = 0;
            endHours = 24;
        }

        Hour = Faker.Randomizer.Next(startHours, endHours);
        return this;
    }

    public DateTimeDifferenceBuilder SetMinutes()
    {
        if (Year == _startDt.Year && Month == _startDt.Month && Day == _startDt.Day && Hour == _startDt.Hour)
        {
            Minute = Faker.Randomizer.Next(_startDt.Minute, 60);
        }
        else if (Year == _endDt.Year && Month == _endDt.Month && Day == _endDt.Day && Hour == _endDt.Hour)
        {
            Minute = Faker.Randomizer.Next(0, _endDt.Minute);
        }
        else
        {
            Minute = Faker.Randomizer.Next(0, 60);
        }

        return this;
    }

    public DateTimeDifferenceBuilder SetSeconds()
    {
        if (Year == _startDt.Year && Month == _startDt.Month && Day == _startDt.Day && Hour == _startDt.Hour && Minute == _startDt.Minute)
        {
            Second = (Faker.Randomizer.Next(_startDt.Second, 60));
        }
        else if (Year == _endDt.Year && Month == _endDt.Month && Day == _endDt.Day && Hour == _endDt.Hour && Minute == _endDt.Minute)
        {
            Second = (Faker.Randomizer.Next(0, _endDt.Second));
        }
        else
        {
            Second = (Faker.Randomizer.Next(0, 60));
        }

        return this;
    }

    public DateTimeDifferenceBuilder SetMilliseconds()
    {
        if (Year == _startDt.Year && Month == _startDt.Month && Day == _startDt.Day && Hour == _startDt.Hour && Minute == _startDt.Minute && Second == _startDt.Second)
        {
            Millisecond = Faker.Randomizer.Next(_startDt.Millisecond, 1000);
        }
        else if (Year == _endDt.Year && Month == _endDt.Month && Day == _endDt.Day && Hour == _endDt.Hour && Minute == _endDt.Minute && Second == _endDt.Second)
        {
            Millisecond = Faker.Randomizer.Next(0, _endDt.Millisecond);
        }
        else
        {
            Millisecond = Faker.Randomizer.Next(0, 1000);
        }

        return this;
    }

    public int Year { get; private set; }

    public int Month { get; private set; }

    public int Day { get; private set; }

    public int Hour { get; private set; }

    public int Minute { get; private set; }

    public int Second { get; private set; }

    public int Millisecond { get; private set; }

    private DateTime _startDt { get; set; }

    private DateTime _endDt { get; set; }
}
