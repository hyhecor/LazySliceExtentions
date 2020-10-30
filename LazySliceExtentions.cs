using System.Collections.Generic;

public static partial class LazySliceExtentions
{
    public static IEnumerable<T> Append<T>(this IEnumerable<T> slice, params T[] new_elements)
    {
        foreach (T e in slice)
            yield return e;

        foreach (T e in new_elements)
            yield return e;
    }

    public static IEnumerable<T> Append<T>(this IEnumerable<T> slice, IEnumerable<T> new_elements)
    {
        foreach (T e in slice)
            yield return e;

        foreach (T e in new_elements)
            yield return e;
    }
}
