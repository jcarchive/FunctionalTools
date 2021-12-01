using System.Collections.Generic;

namespace Jcarchive.FunctionalTools
{
    public static partial class Generators
    {
        public static ISet<TSource> ToSet<TSource>(IEnumerable<TSource> arr)
        {
            return new HashSet<TSource>(arr);
        }
        public static ISet<TSource> ToSet<TSource>(params TSource[] arr)
        {
            return new HashSet<TSource>(arr);
        }
        
        public static IReadOnlySet<TSource> ToReadOnlySet<TSource>(IEnumerable<TSource> arr)
        {
            return new HashSet<TSource>(arr);
        }
        public static IReadOnlySet<TSource> ToReadOnlySet<TSource>(params TSource[] arr)
        {
            return new HashSet<TSource>(arr);
        }
    }
}