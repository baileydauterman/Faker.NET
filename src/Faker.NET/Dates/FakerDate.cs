using Faker.NET.Extensions;
using Faker.NET.Interfaces;

namespace Faker.NET.Dates;

public class FakerDate : IFakerDate
{
    public DateTime Anytime()
    {
        return Between();
    }

    public DateTime Between(DateTime? start = null, DateTime? end = null)
    {
        start ??= DateTime.MinValue;
        end ??= DateTime.MaxValue;

        if (start > end)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        var newDateTime = Faker.Randomizer.Next(start.Value.Year, end.Value.Year).ToDateTime();
        newDateTime.AddMonthsInBetweenDates(start.Value, end.Value);
        newDateTime.AddDaysInBetweenDates(start.Value, end.Value);
        newDateTime.AddHoursInBetweenDates(start.Value, end.Value);
        newDateTime.AddMinutesInBetweenDates(start.Value, end.Value);
        newDateTime.AddSecondsInBetweenDates(start.Value, end.Value);
        newDateTime.AddMillisecondsInBetweenDates(start.Value, end.Value);

        return newDateTime;
    }

    public IEnumerable<DateTime> Betweens(int? count = 5, DateTime? start = null, DateTime? end = null)
    {
        while (count-- > 0)
        {
            yield return Between(start, end);
        }
    }

    public DateTime Birthdate()
    {
        throw new NotImplementedException();
    }

    public DateTime Future(DateTime? farthestDate = null)
    {
        farthestDate ??= DateTime.MaxValue;
        return Between(DateTime.Now, farthestDate);
    }

    public DateTime Month()
    {
        throw new NotImplementedException();
    }

    public DateTime Past(DateTime? earliestDate = null)
    {
        earliestDate ??= DateTime.MinValue;
        return Between(earliestDate, DateTime.Now);
    }

    public DateTime Recent(int days = 5)
    {
        if (days < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(days));
        }

        days = 0 - days;
        var start = DateTime.Now.AddDays(days);
        return Between(start, DateTime.Now);
    }

    public DateTime Soon(int days = 5)
    {
        var end = DateTime.Now.AddDays(days);
        return Between(DateTime.Now, end);
    }

    public DateTime TimeZone()
    {
        throw new NotImplementedException();
    }

    public DateTime Weekday()
    {
        throw new NotImplementedException();
    }
}
