using Faker.NET.Extensions;

namespace Faker.NET.Common;

public class WeightedList<T>
{
    public WeightedList()
    {

    }

    public WeightedList(Dictionary<T, int> weights)
    {
        foreach (var weight in weights)
        {
            Add(weight.Key, weight.Value);
        }
    }

    public void Add(T value, int weight)
    {
        _values.Add(value);
        _weights.Add(_totalWeight.ToRangeArray(weight + _totalWeight));
        _totalWeight += weight;
    }

    /// <summary>
    /// Gets a value by its weight.
    /// </summary>
    /// <returns>The value or <see langword="null"/> if unable to find value (shouldn't happen)</returns>
    public T? GetValue()
    {
        var value = Faker.Randomizer.Next(_totalWeight);

        for (int i = 0; i < _weights.Count; i++)
        {
            if (_weights[i].Contains(value))
            {
                return _values[i];
            }
        }

        return default;
    }

    private List<T> _values = new List<T>();
    private List<int[]> _weights = new List<int[]>();
    private int _totalWeight = 0;
}
