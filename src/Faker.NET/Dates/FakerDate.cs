using System.Globalization;
using Faker.NET.Extensions;
using Faker.NET.Interfaces;

namespace Faker.NET.Dates;

public class FakerDate : IFakerDate
{
    /// <summary>
    /// Get any date between <see cref="DateTime.MinValue"/> to <see cref="DateTime.MaxValue"/>
    /// </summary>
    /// <returns>The randomized <see cref="DateTime"/></returns>
    public DateTime Anytime()
    {
        return Between();
    }

    /// <summary>
    /// Get a random <see cref="DateTime"/> between <paramref name="start"/> and <paramref name="end"/>
    /// </summary>
    /// <param name="start">The starting time of the range (defaults to <see cref="DateTime.MinValue")/></param>
    /// <param name="end">The ending time of the range (defaults to <see cref="DateTime.MaxValue"/>)</param>
    /// <returns>The randomized <see cref="DateTime"/> between <paramref name="start"/> and <paramref name="end"/></returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the start is greater than the end date time</exception>
    public DateTime Between(DateTime? start = null, DateTime? end = null)
    {
        start ??= DateTime.MinValue;
        end ??= DateTime.MaxValue;

        if (start > end)
        {
            throw new ArgumentOutOfRangeException(nameof(start));
        }

        var newDateTime = new DateTimeDifferenceBuilder(start.Value, end.Value)
                                .SetMonths()
                                .SetDays()
                                .SetHours()
                                .SetMinutes()
                                .SetSeconds()
                                .SetMilliseconds()
                                .Build();

        return newDateTime;
    }

    /// <summary>
    /// Returns multiple <see cref="DateTime"/> values with a length equal to <paramref name="count"/>
    /// </summary>
    /// <param name="count">The number of values to return</param>
    /// <param name="start">The starting time of the range (defaults to <see cref="DateTime.MinValue")/></param>
    /// <param name="end">The ending time of the range (defaults to <see cref="DateTime.MaxValue"/>)</param>
    /// <returns>Multiple <see cref="DateTime"/> values</returns>
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

    /// <summary>
    /// Gets a random <see cref="DateTime"/> in the future.
    /// </summary>
    /// <param name="farthestDate">The maximum date time value in the future</param>
    /// <returns>The future <see cref="DateTime"/> value</returns>
    public DateTime Future(DateTime? farthestDate = null)
    {
        farthestDate ??= DateTime.MaxValue;
        return Between(DateTime.Now, farthestDate);
    }

    /// <summary>
    /// Gets a random month
    /// </summary>
    /// <param name="abbreviated">Whether or not the month should be abbreviated</param>
    /// <param name="useCurrentFakerCulture">Whether or not to use the <see cref="DateTimeFormatInfo.CurrentInfo"/> of <see cref="Faker.Culture.DateTimeFormat"/></param>
    /// <returns>A random month as a string</returns>
    public string Month(bool abbreviated = false, bool useCurrentFakerCulture = true)
    {
        var dateTimeInfo = useCurrentFakerCulture ? Faker.Culture.DateTimeFormat : DateTimeFormatInfo.CurrentInfo;
        return (abbreviated ? dateTimeInfo.AbbreviatedMonthNames : dateTimeInfo.MonthNames).GetRandom();
    }

    /// <summary>
    /// Gets a random <see cref="DateTime"/> in the past
    /// </summary>
    /// <param name="earliestDate">The earliest a date time can be</param>
    /// <returns>A random <see cref="DateTime"/> in the past</returns>
    public DateTime Past(DateTime? earliestDate = null)
    {
        earliestDate ??= DateTime.MinValue;
        return Between(earliestDate, DateTime.Now);
    }

    /// <summary>
    /// Gets a random <see cref="DateTime"/> that happened since <paramref name="days"/>
    /// </summary>
    /// <param name="days">Days ago, relative to the current datetime</param>
    /// <returns>A random <see cref="DateTime"/> in the past within the last <paramref name="days"/> days</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
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

    /// <summary>
    /// Gets a random <see cref="DateTime"/> that will happen in the next <paramref name="days"/>
    /// </summary>
    /// <param name="days">Days until, relative to the current datetime</param>
    /// <returns>A random <see cref="DateTime"/> in the past within the last <paramref name="days"/> days</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public DateTime Soon(int days = 5)
    {
        var end = DateTime.Now.AddDays(days);
        return Between(DateTime.Now, end);
    }

    /// <summary>
    /// Gets a random <see cref="TimeZoneInfo"/>
    /// </summary>
    /// <returns>The random <see cref="TimeZoneInfo"/></returns>
    public TimeZoneInfo TimeZone()
    {
        return TimeZoneInfo.GetSystemTimeZones().GetRandom();
    }

    /// <summary>
    /// Gets a random day of the week
    /// </summary>
    /// <param name="abbreviated">Whether or not the weekday should be abbreviated</param>
    /// <param name="useCurrentFakerCulture">Whether or not to use the <see cref="DateTimeFormatInfo.CurrentInfo"/> of <see cref="Faker.Culture.DateTimeFormat"/></param>
    /// <returns>A random weekday as a string</returns>
    public string Weekday(bool abbreviated = false, bool useCurrentFakerCulture = true)
    {
        var dateTimeInfo = useCurrentFakerCulture ? Faker.Culture.DateTimeFormat : DateTimeFormatInfo.CurrentInfo;
        return (abbreviated ? dateTimeInfo.AbbreviatedDayNames : dateTimeInfo.DayNames).GetRandom();
    }
}
