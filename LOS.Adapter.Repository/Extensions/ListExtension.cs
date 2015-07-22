using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LOS.Adapter.Data.Services.Extensions
{
    /// <summary>
    /// Extension Methods for Collection
    /// </summary>
    public static class ListExtension
    {
        /// <summary>
        /// Removes the null or empty items within a List where string properties are null or empty elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        public static void RemoveNullOrEmpty<T>(this List<T> list)
        {
            var stringProperties = typeof(T)
                                    .GetProperties()
                                    .Where(p => p.PropertyType == typeof(string))
                                    .ToArray();
            list.RemoveAll(o => stringProperties
                                .All(p => string.IsNullOrEmpty((string)p.GetValue(o))));
        }

        /// <summary>
        /// Adds the repeat default values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <param name="count">The count.</param>
        public static void AddRepeatDefaultValues<T>(this List<T> list, int count)
        {
            Repeated(list, default(T), count);
        }

        /// <summary>
        /// Repeatd the specified List.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ret">The ret.</param>
        /// <param name="value">The value.</param>
        /// <param name="count">The count.</param>
        /// <returns></returns>
        public static List<T> Repeated<T>(List<T> ret, T value, int count)
        {
            ret.AddRange(Enumerable.Repeat(value, count));
            return ret;
        }

        /// <summary>
        /// Determines whether [is null or empty] [the specified enumerable].
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
                return true;

            return !enumerable.Any();
        }

        /// <summary>
        /// Modifies for specific count.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <param name="count">The count.</param>
        public static void AddOrTrimExcess<T>(this List<T> list, int count)
        {
            if (list.Count == count)
                return;
            //More elements
            else if (list.Count < count)
            {
                AddRepeatDefaultValues(list, count - list.Count);
            }
            //Less elements
            else
            {
                list.RemoveRange(count, list.Count - count);
            }
        }
    }




    public class FastConcat<T> : IEnumerable<T>
    {
        LinkedList<T[]> _items = new LinkedList<T[]>();
        int _count;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public void Add(T[] items)
        {
            if (items == null)
                return;
            if (items.Length == 0)
                return;

            _items.AddLast(items);
            _count += items.Length;
        }

        private T[] GetItemIndex(int realIndex, out int offset)
        {
            offset = 0; // Offset that needs to be applied to realIndex.
            int currentStart = 0; // Current index start.

            foreach (T[] items in _items)
            {
                currentStart += items.Length;
                if (currentStart > realIndex)
                    return items;
                offset = currentStart;
            }
            return null;
        }

        public T this[int index]
        {
            get
            {
                int offset;
                T[] i = GetItemIndex(index, out offset);
                return i[index - offset];
            }
            set
            {
                int offset;
                T[] i = GetItemIndex(index, out offset);
                i[index - offset] = value;
            }
        }

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return _items.SelectMany(items => items).GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
