using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Jcarchive.FunctionalTools
{
    public static partial class Extensions
    {
        /// <summary>
        /// Execute a given function for each element in an enumerable
        /// <example>
        /// <code>
        /// FromRange(1, 10).ForEach(Console.Write);
        /// </code>
        /// Prints '123456789' on console
        /// </example>
        /// </summary>
        /// <param name="enumerable">a enumerable</param>
        /// <param name="function">a function</param>
        /// <typeparam name="T">Data type</typeparam>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> function)
        {
            foreach (var o in enumerable)
            {
                function(o);
            }
        }
    }
}