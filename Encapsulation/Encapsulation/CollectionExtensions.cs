namespace Encapsulation
{
    using System.Collections.Generic;

    public static class CollectionExtensions
    {
        public static bool IsEmpty<T>(this ICollection<T> collection)
        {
            return collection.Count == 0;
        }
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> elements)
        {
            foreach (var item in elements)
            {
                collection.Add(item);
            }
        }
    }
}