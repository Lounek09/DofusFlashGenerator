namespace DofusFlashGenerator.Utils;

public static class ExtendIReadOnlyList
{
    public static int FindIndex<T>(this IReadOnlyList<T> list, Predicate<T> match)
    {
        for (var i = 0; i < list.Count; i++)
        {
            if (match(list[i]))
            {
                return i;
            }
        }

        return -1;
    }
}
