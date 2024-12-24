using System;

namespace Faker.NET.Extensions;

public static class DateTimeExtensions
{
    public static DateTime ToDateTime(this int year)
    {
        return new DateTime(year, 1, 1);
    }

    public static void AddMonthsInBetweenDates(this DateTime newDt, DateTime start, DateTime end)
    {
        if (newDt.Year == start.Year)
        {
            newDt.AddMonths(Faker.Randomizer.Next(start.Month, 12));
        }
        else if (newDt.Year == end.Year)
        {
            newDt.AddMonths(Faker.Randomizer.Next(1, end.Month));
        }
        else
        {
            newDt.AddMonths(Faker.Randomizer.Next(1, 13));
        }
    }

    public static void AddDaysInBetweenDates(this DateTime newDt, DateTime start, DateTime end)
    {
        var daysInMonth = DateTime.DaysInMonth(newDt.Year, newDt.Month);
        if (newDt.Year == start.Year && newDt.Month == start.Month)
        {
            newDt.AddDays(Faker.Randomizer.Next(start.Day, daysInMonth));
        }
        else if (newDt.Year == end.Year && newDt.Month == end.Month)
        {
            newDt.AddDays(Faker.Randomizer.Next(1, end.Day));
        }
        else
        {
            newDt.AddDays(Faker.Randomizer.Next(1, daysInMonth));
        }
    }

    public static void AddHoursInBetweenDates(this DateTime newDt, DateTime start, DateTime end)
    {
        if (newDt.Year == start.Year && newDt.Month == start.Month && newDt.Day == start.Day)
        {
            newDt.AddHours(Faker.Randomizer.Next(start.Hour, 24));
        }
        else if (newDt.Year == end.Year && newDt.Month == end.Month && newDt.Day == end.Day)
        {
            newDt.AddHours(Faker.Randomizer.Next(0, end.Hour));
        }
        else
        {
            newDt.AddHours(Faker.Randomizer.Next(0, 24));
        }
    }

    public static void AddMinutesInBetweenDates(this DateTime newDt, DateTime start, DateTime end)
    {
        if (newDt.Year == start.Year && newDt.Month == start.Month && newDt.Day == start.Day && newDt.Hour == start.Hour)
        {
            newDt.AddMinutes(Faker.Randomizer.Next(start.Minute, 60));
        }
        else if (newDt.Year == end.Year && newDt.Month == end.Month && newDt.Day == end.Day && newDt.Hour == end.Hour)
        {
            newDt.AddMinutes(Faker.Randomizer.Next(0, end.Minute));
        }
        else
        {
            newDt.AddMinutes(Faker.Randomizer.Next(0, 60));
        }
    }

    public static void AddSecondsInBetweenDates(this DateTime newDt, DateTime start, DateTime end)
    {
        if (newDt.Year == start.Year && newDt.Month == start.Month && newDt.Day == start.Day && newDt.Hour == start.Hour && newDt.Minute == start.Minute)
        {
            newDt.AddSeconds(Faker.Randomizer.Next(start.Second, 60));
        }
        else if (newDt.Year == end.Year && newDt.Month == end.Month && newDt.Day == end.Day && newDt.Hour == end.Hour && newDt.Minute == end.Minute)
        {
            newDt.AddSeconds(Faker.Randomizer.Next(0, end.Second));
        }
        else
        {
            newDt.AddSeconds(Faker.Randomizer.Next(0, 60));
        }
    }

    public static void AddMillisecondsInBetweenDates(this DateTime newDt, DateTime start, DateTime end)
    {
        if (newDt.Year == start.Year && newDt.Month == start.Month && newDt.Day == start.Day && newDt.Hour == start.Hour && newDt.Minute == start.Minute && newDt.Second == start.Second)
        {
            newDt.AddMilliseconds(Faker.Randomizer.Next(start.Millisecond, 1000));
        }
        else if (newDt.Year == end.Year && newDt.Month == end.Month && newDt.Day == end.Day && newDt.Hour == end.Hour && newDt.Minute == end.Minute && newDt.Second == end.Second)
        {
            newDt.AddMilliseconds(Faker.Randomizer.Next(0, end.Millisecond));
        }
        else
        {
            newDt.AddMilliseconds(Faker.Randomizer.Next(0, 1000));
        }
    }
}
