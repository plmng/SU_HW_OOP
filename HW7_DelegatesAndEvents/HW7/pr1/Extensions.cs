namespace pr1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(
            this IEnumerable<T> collection, Predicate<T> predicate)
        {
            return collection.Where(element => !predicate(element)).ToList();
        }

        public static TResult Maximum<TSource, TResult>(
            this IEnumerable<TSource> collection, Func<TSource, TResult> function)
            where TResult : IComparable<TResult>
        {
            var result = collection.Select(function).ToList();

            var max = result[0];
            for (var i = 1; i < result.Count; i++)
            {
                if (result[i].CompareTo(max) > 0)
                {
                    max = result[i];
                }
            }

            return max;
        }
    }
}
