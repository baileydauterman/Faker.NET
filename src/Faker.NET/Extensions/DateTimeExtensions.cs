namespace Faker.NET.Extensions;

public static class DateTimeExtensions
{
    public static DateTime ToDateTime(this int year)
    {
        return new DateTime(year, 1, 1);
    }

    public static void AddMonthsInBetweenDates(ref this DateTime newDt, DateTime start, DateTime end)
    {
        if (newDt.Year == start.Year)
        {
            newDt = newDt.AddMonths(Faker.Randomizer.Next(start.Month, 12));
        }
        else if (newDt.Year == end.Year)
        {
            newDt = newDt.AddMonths(Faker.Randomizer.Next(1, end.Month));
        }
        else
        {
            newDt = newDt.AddMonths(Faker.Randomizer.Next(1, 13));
        }
    }

    public static void AddDaysInBetweenDates(ref this DateTime newDt, DateTime start, DateTime end)
    {
        var daysInMonth = DateTime.DaysInMonth(newDt.Year, newDt.Month);
        if (newDt.Year == start.Year && newDt.Month == start.Month)
        {
            newDt = newDt.AddDays(Faker.Randomizer.Next(start.Day, daysInMonth));
        }
        else if (newDt.Year == end.Year && newDt.Month == end.Month)
        {
            newDt = newDt.AddDays(Faker.Randomizer.Next(1, end.Day));
        }
        else
        {
            newDt = newDt.AddDays(Faker.Randomizer.Next(1, daysInMonth));
        }
    }

    public static void AddHoursInBetweenDates(ref this DateTime newDt, DateTime start, DateTime end)
    {
        int startHours, endHours;
        if (newDt.Year == start.Year && newDt.Month == start.Month && newDt.Day == start.Day)
        {
            startHours = start.Hour;
            endHours = 24;
        }
        else if (newDt.Year == end.Year && newDt.Month == end.Month && newDt.Day == end.Day)
        {
            startHours = 0;
            endHours = end.Hour;
        }
        else
        {
            startHours = 0;
            endHours = 24;
        }

        newDt = newDt.AddHours(Faker.Randomizer.Next(startHours, endHours));
    }

    public static void AddMinutesInBetweenDates(ref this DateTime newDt, DateTime start, DateTime end)
    {
        if (newDt.Year == start.Year && newDt.Month == start.Month && newDt.Day == start.Day && newDt.Hour == start.Hour)
        {
            newDt = newDt.AddMinutes(Faker.Randomizer.Next(start.Minute, 60));
        }
        else if (newDt.Year == end.Year && newDt.Month == end.Month && newDt.Day == end.Day && newDt.Hour == end.Hour)
        {
            newDt = newDt.AddMinutes(Faker.Randomizer.Next(0, end.Minute));
        }
        else
        {
            newDt = newDt.AddMinutes(Faker.Randomizer.Next(0, 60));
        }
    }

    public static void AddSecondsInBetweenDates(ref this DateTime newDt, DateTime start, DateTime end)
    {
        if (newDt.Year == start.Year && newDt.Month == start.Month && newDt.Day == start.Day && newDt.Hour == start.Hour && newDt.Minute == start.Minute)
        {
            newDt = newDt.AddSeconds(Faker.Randomizer.Next(start.Second, 60));
        }
        else if (newDt.Year == end.Year && newDt.Month == end.Month && newDt.Day == end.Day && newDt.Hour == end.Hour && newDt.Minute == end.Minute)
        {
            newDt = newDt.AddSeconds(Faker.Randomizer.Next(0, end.Second));
        }
        else
        {
            newDt = newDt.AddSeconds(Faker.Randomizer.Next(0, 60));
        }
    }

    public static void AddMillisecondsInBetweenDates(ref this DateTime newDt, DateTime start, DateTime end)
    {
        if (newDt.Year == start.Year && newDt.Month == start.Month && newDt.Day == start.Day && newDt.Hour == start.Hour && newDt.Minute == start.Minute && newDt.Second == start.Second)
        {
            newDt = newDt.AddMilliseconds(Faker.Randomizer.Next(start.Millisecond, 1000));
        }
        else if (newDt.Year == end.Year && newDt.Month == end.Month && newDt.Day == end.Day && newDt.Hour == end.Hour && newDt.Minute == end.Minute && newDt.Second == end.Second)
        {
            newDt = newDt.AddMilliseconds(Faker.Randomizer.Next(0, end.Millisecond));
        }
        else
        {
            newDt = newDt.AddMilliseconds(Faker.Randomizer.Next(0, 1000));
        }
    }
}
