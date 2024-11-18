namespace DofusFlashGenerator.Extensions;

public static class IReadOnlyListExtension
{
    public static int FindIndex<T>(this IReadOnlyList<T> source, Predicate<T> predicate)
    {
        if (source is List<T> list)
        {
            return list.FindIndex(predicate);
        }

        var count = source.Count;
        for (var i = 0; i < count; i++)
        {
            if (predicate(source[i]))
            {
                return i;
            }
        }

        return -1;
    }

    public static int FindLastIndex<T>(this IReadOnlyList<T> source, Predicate<T> predicate)
    {
        if (source is List<T> list)
        {
            return list.FindLastIndex(predicate);
        }

        for (var i = source.Count - 1; i >= 0; i--)
        {
            if (predicate(source[i]))
            {
                return i;
            }
        }

        return -1;
    }
}
