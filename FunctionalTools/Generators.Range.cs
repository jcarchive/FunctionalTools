using System;
using System.Collections;
using System.Collections.Generic;

namespace Jcarchive.FunctionalTools
{
    public static partial class Generators
    {
        public static IEnumerable<T> FromRange<T>(T start, T end, T step, Func<T,T,T> Add) where T: IComparable<T>
        {
            var current = start;

            var direction = start.CompareTo(end);
            switch (direction)
            {
                // start precedes end so is an upward generation
                case < 0:
                {
                    while (current.CompareTo(end) < 0)
                    {
                        yield return current;
                        current = Add(current, step);
                    }

                    break;
                }
                //start is equal to end so just finish
                case 0:
                    yield return  current;
                    yield break;
                default:
                {
                    while (current.CompareTo(end) > 0) //start follows end so is an downward generation
                    {
                        yield return current;
                        current = Add(current, step);
                    }

                    break;
                }
            }
        }

        public static IEnumerable<double> FromRange(double start, double end, double step = 1)
        {
            return FromRange(start, end, step, (a, b) => a + b);
        }
        
        public static IEnumerable<float> FromRange(float start, float end, float step = 1)
        {
            return FromRange(start, end, step, (a, b) => a + b);
        }
        
        public static IEnumerable<decimal> FromRange(decimal start, decimal end, decimal step = 1)
        {
            return FromRange(start, end, step, (a, b) => a + b);
        }
        
        public static IEnumerable<int> FromRange(int start, int end, int step = 1)
        {
            return FromRange(start, end, step, (a, b) => a + b);
        }
        
        public static IEnumerable<uint> FromRange(uint start, uint end, uint step = 1)
        {
            return FromRange(start, end, step, (a, b) => a + b);
        }
        
        public static IEnumerable<ulong> FromRange(ulong start, ulong end, ulong step = 1)
        {
            return FromRange(start, end, step, (a, b) => a + b);
        }
        
        public static IEnumerable<long> FromRange(long start, long end, long step = 1)
        {
            return FromRange(start, end, step, (a, b) => a + b);
        }
    }
}