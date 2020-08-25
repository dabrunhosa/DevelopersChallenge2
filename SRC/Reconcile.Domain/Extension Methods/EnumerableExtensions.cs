using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.ExtensionMethods
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<IList<T>> ChunkOn<T>(this IEnumerable<T> source, Func<T, bool> startChunk)
        {
            List<T> list = new List<T>();

            foreach (var item in source)
            {
                if (startChunk(item) && list.Count > 0)
                {
                    yield return list;
                    list = new List<T>();
                }

                list.Add(item);
            }

            if (list.Count > 0)
            {
                yield return list;
            }
        }
    }
}
