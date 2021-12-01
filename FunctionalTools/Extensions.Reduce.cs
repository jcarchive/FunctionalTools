using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Jcarchive.FunctionalTools
{
    public static partial class Extensions
    {
        /// <summary>
        /// Reduce a enumerable by a given function aggregator
        /// <example>
        /// <code>
        /// var numbers = FromRange(1, 10); // { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
        /// var sum = numbers.Reduce<![CDATA[<int,int>]]>((acc, current) => acc + current)); // 45
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="enumerable"> a enumerable</param>
        /// <param name="function"> a function</param>
        /// <param name="start"> the initial value</param>
        /// <typeparam name="TSource"> source data type</typeparam>
        /// <typeparam name="TResult"> result aggregator fata type </typeparam>
        /// <returns></returns>
        public static TResult Reduce<TSource, TResult>(
            this IEnumerable<TSource> enumerable,
            Func<TResult, TSource, TResult> function,
            TResult start = default(TResult))
        {
            var acc = start;
            enumerable.ForEach(source => acc = function(acc, source));
            return acc;
        }
    }
}