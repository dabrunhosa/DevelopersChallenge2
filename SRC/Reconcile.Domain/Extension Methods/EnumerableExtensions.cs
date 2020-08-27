using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.ExtensionMethods
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> ChunkOn<T>(this IEnumerable<T> source,
            Func<T, bool> startChunk, Func<T, bool> endChunk)
        {
            bool continueYield = false;

            foreach (var item in source)
            {
                if (startChunk(item))
                    continueYield = !continueYield;

                if (continueYield)
                    yield return item;

                if (endChunk(item))
                {
                    continueYield = !continueYield;
                    break;
                }
            }
        }
    }
}
