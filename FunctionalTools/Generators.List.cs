using System.Collections.Generic;

namespace Jcarchive.FunctionalTools
{
    public static partial class Generators
    {
        public static IList<TSource> ToList<TSource>(IEnumerable<TSource> arr)
        {
            return new List<TSource>(arr);
        }
        public static IList<TSource> ToList<TSource>(params TSource[] arr)
        {
            return new List<TSource>(arr);
        }
        
        public static IReadOnlyList<TSource> ToReadOnlyList<TSource>(IEnumerable<TSource> arr)
        {
            return new List<TSource>(arr);
        }
        public static IReadOnlyList<TSource> ToReadOnlyList<TSource>(params TSource[] arr)
        {
            return new List<TSource>(arr);
        }
    }
}