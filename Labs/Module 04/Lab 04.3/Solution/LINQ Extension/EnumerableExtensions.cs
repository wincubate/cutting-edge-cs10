using System.Runtime.CompilerServices;

static class EnumerableExtensions
{
    public static IEnumerable<T> Sample<T>(
        this IEnumerable<T> sequence,
        int frequency,
        [CallerArgumentExpression("sequence")] string? message = null)
    {
        if (sequence.Count() < frequency)
        {
            throw new ArgumentException($"Expression doesn't have enough elements:{Environment.NewLine}{message}",
                nameof(sequence));
        }

        int i = 0;
        foreach (T item in sequence)
        {
            if (i++ % frequency == 0)
            {
                yield return item;
            }
        }
    }
}