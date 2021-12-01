using System;
using System.Collections;
using System.Collections.Generic;

namespace Jcarchive.FunctionalTools
{
    public static partial class Generators
    {
        /// <summary>
        /// Generate a ICollection from a enumerable
        /// <code>
        /// var odds = ToCollection(FromRange(1, 10))
        /// </code>
        /// </summary>
        /// <param name="enumerable"> a enumerable</param>
        /// <typeparam name="TSource"> origin data type</typeparam>
        /// <returns>
        /// ICollection with the same elements that the origin
        /// </returns>
        public static ICollection<TSource> ToCollection<TSource>(IEnumerable<TSource> enumerable)
        {
            return new List<TSource>(enumerable);
        }
        
        /// <summary>
        /// Generates an ICollection from the source data
        /// <code>
        /// var numbers = ToCollection(1, 2, 3, 4, 5, 6);
        /// </code>
        /// </summary>
        /// <param name="data"></param>
        /// <typeparam name="TSource"></typeparam>
        /// <returns>
        /// ICollection with the given elements
        /// </returns>
        public static ICollection<TSource> ToCollection<TSource>(params TSource[] data)
        {
            return new List<TSource>(data);
        }
        
        /// <summary>
        /// Generate a IReadOnlyCollection from a enumerable
        /// <code>
        /// var odds = ToReadOnlyCollection(FromRange(1, 10));
        /// </code>
        /// </summary>
        /// <param name="enumerable"> a enumerable</param>
        /// <typeparam name="TSource"> origin data type</typeparam>
        /// <returns>
        /// IReadOnlyCollection with the same elements that the origin
        /// </returns>
        public static IReadOnlyCollection<TSource> ToReadOnlyCollection<TSource>(IEnumerable<TSource> enumerable)
        {
            return new List<TSource>(enumerable);
        }
        
        /// <summary>
        /// Generates an IReadOnlyCollection from the source data
        /// <code>
        /// var numbers = ToReadOnlyCollection(1, 2, 3, 4, 5, 6);
        /// </code>
        /// </summary>
        /// <param name="data"></param>
        /// <typeparam name="TSource"></typeparam>
        /// <returns>
        /// IReadOnlyCollection with the given elements
        /// </returns>
        public static IReadOnlyCollection<TSource> ToReadOnlyCollection<TSource>(params TSource[] data)
        {
            return new List<TSource>(data);
        }
    }
}