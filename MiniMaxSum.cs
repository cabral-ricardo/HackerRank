using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class MiniMaxSum
    {
        public static string GetMinMaxSum(long[] arr)
        {
            Array.Sort(arr);

            long Min = arr[0];
            long Max = arr[arr.Length - 1];

            if (!arr.Distinct().Skip(1).Any())
            {
                arr = arr.Take(arr.Length - 1).ToArray();
                Max += 1;
                Min = 0;
            }

            long sumMin = (from x in arr where x < Max select x).Sum();
            long sumMax = (from x in arr where x > Min select x).Sum();

            return String.Format("{0}-{1}", sumMin.ToString(), sumMax.ToString());
        }
    }
}
