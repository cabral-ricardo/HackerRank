using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class BirthdayCakeCandles
    {
        /// <summary>
        /// Return count of candle with highest value
        /// </summary>
        /// <param name="ar"></param>
        /// <returns></returns>
        public static string GetBirthdayCakeCandles(long[] ar)
        {
            ar = (from x in ar orderby x descending select x).ToArray();

            long max = ar[0];
            long count = 0;

            foreach (var item in ar)
            {
                if (max != item)
                {
                    break;
                }

                count++;
            }

            return count.ToString();
        }
    }
}
