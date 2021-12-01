using System;
using System.Collections;
using System.Collections.Generic;

namespace Jcarchive.FunctionalTools
{
    public static partial class Generators
    {
        public static IEnumerable<T> FromGenerator<T>( int capacity, Func<int, T> generator)
        {
            var i = 0;
            while (i < capacity)
            {
                yield return generator(i);
                i++;
            }
        }
    }
}