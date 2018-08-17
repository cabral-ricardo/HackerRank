using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            InicializeBirthdayCakeCandles();
            InicializeTimeConversion();
        }

        static void InicializeBirthdayCakeCandles()
        {
            long[] numeros = { 1, 3, 2, 3};
            BirthdayCakeCandles(numeros);
        }

        static void BirthdayCakeCandles(long[] ar)
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

            Console.WriteLine(count.ToString());


        }


        static void InicializeTimeConversion()
        {
            TimeConversion("07:05:45PM");
        }

        static void TimeConversion(string s)
        {
            DateTime dt = Convert.ToDateTime(s);
            
            Console.WriteLine("{0}", dt.ToString("HH:mm:ss"));

        }


    }
}
