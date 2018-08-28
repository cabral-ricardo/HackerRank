using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class CircularArrayRotation
    {
        public static IEnumerable<T> ShiftRight<T>(IList<T> values, int rotation)
        {
            for (int index = 0; index < values.Count; index++)
            {
                yield return values[MathMod(index - rotation, values.Count)];
            }
        }

        public static int[] ShiftRightIntArray(int[] values, int rotation)
        {
            int size = values.Count();
            int[] result = new int[size];

            for (int index = 0; index < values.Count(); index++)
            {
                result[index] = values[MathMod(index - rotation, size)];
            }

            return result;
        }

        private static int MathMod(int a, int b)
        {
            int c = ((a % b) + b) % b;
            return c;
        }

        public static int[] GetCircularArrayRotation(int[] a, int k, int[] queries)
        {
            int[] ret = ShiftRightIntArray(a, k);

            return FilterQueries(ret, queries);
        }

        private static int[] FilterQueries(int[] ret, int[] queries)
        {
            int[] result = new int[queries.Count()];

            for (int index = 0; index < queries.Count(); index++)
            {
                result[index] = ret[queries[index]];
            }

            return result;
        }
    }
}
