using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class CompareTriplets
    {
        public static string GetCompareTriplets(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int alexScore = 0;
            int bobScore = 0;

            if (a0 != b0)
            {
                switch (a0 > b0)
                {
                    case true:
                        alexScore++;
                        break;
                    case false:
                        bobScore++;
                        break;
                    default:
                        break;
                }
            }
                
            if (a1 != b1)
            {
                switch (a1 > b1)
                {
                    case true:
                        alexScore++;
                        break;
                    case false:
                        bobScore++;
                        break;
                    default:
                        break;
                }
            }
                
            if (a2 != b2)
            {
                switch (a2 > b2)
                {
                    case true:
                        alexScore++;
                        break;
                    case false:
                        bobScore++;
                        break;
                    default:
                        break;
                }
            }   

            int[] scoreArr = { alexScore, bobScore };

            return string.Format("{0}-{1}", scoreArr[0], scoreArr[1]);
        }
    }
}
