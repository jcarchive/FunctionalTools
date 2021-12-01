using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Jcarchive.FunctionalTools
{
    public static partial class Extensions
    {
        /// <summary>
        /// Filters a enumerable by a given function
        /// <example>
        /// <code>
        /// var odds = FromRange(1, 10).Filter( n => n%2 == 1);
        /// </code>
        /// Results in odds having { 1, 3, 5, 7, 9 }
        /// </example>
        /// </summary>
        /// <param name="enumerable">Origin enumerable data</param>
        /// <param name="function">a function</param>
        /// <typeparam name="T">Data type</typeparam>
        /// <returns></returns>
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> enumerable, Func<T, bool> function)
        {
            return enumerable.Where(function).Select(el => el);
        }
        
        /// <summary>
        /// Filters a enumerable by a given function with index
        /// <example>
        /// <code>
        /// var oddLetters = ToCollection("a", "b", "c", "d").Filter((index, element) => index >= 2); // { "c", "d" }
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="enumerable">Origin enumerable data</param>
        /// <param name="function">a function</param>
        /// <typeparam name="T">Data type</typeparam>
        /// <returns></returns>
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> enumerable, Func<int, T, bool> function)
        {
            var i = 0;
            foreach (var el in enumerable)
            {
                if (function(i, el))
                    yield return el;
                i++;
            }
        }
    }
}