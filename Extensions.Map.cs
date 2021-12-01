using System;
using System.Collections.Generic;
using System.Linq;

namespace Jcarchive.FunctionalTools
{
    public static partial class Extensions
    {
        /// <summary>
        /// Transform each element from the source enumerable to a distinct type element in a result enumerable
        /// <example>
        /// <code>
        /// var numbers = FromRange(1, 10); // { 1, 2, 3 ,4 ,5 ,6 7, 8, 9 }
        /// var oddsFlags = numbers.Map( el => el%2 == 1 ); // { True, False, True, False, True, False, True, False, True }
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="enumerable"> a enumerable</param>
        /// <param name="function"> a function</param>
        /// <typeparam name="TSource">source data type</typeparam>
        /// <typeparam name="TResult">goal data type</typeparam>
        /// <returns></returns>
        public static IEnumerable<TResult> Map<TSource, TResult>(this IEnumerable<TSource> enumerable, Func<TSource, TResult> function)
        {
            return enumerable.Select(function);
        }
    }
}