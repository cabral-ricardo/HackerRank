using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            InicializeMiniMaxSum();
            InicializeBirthdayCakeCandles();
            InicializeTimeConversion();
        }

        static void InicializeMiniMaxSum()
        {
            long[] numeros = { 5, 4, 3, 2, 1 };
            MiniMaxSum(numeros);

            numeros = new long[] { 7, 69, 2, 221, 8974 };
            MiniMaxSum(numeros);

            numeros = new long[] { 5, 5, 5, 5, 5 };
            MiniMaxSum(numeros);
        }

        static void MiniMaxSum(long[] arr)
        {
            Array.Sort(arr);

            long Min = arr[0];
            long Max = arr[arr.Length -1];

            if (!arr.Distinct().Skip(1).Any()) {
                arr = arr.Take(arr.Length - 1).ToArray();
                Max += 1;
                Min = 0;
            }

            long sumMin = (from x in arr where x < Max select x).Sum();
            long sumMax = (from x in arr where x > Min select x).Sum();
            
            Console.Write(String.Format("{0} {1}", sumMin.ToString(), sumMax.ToString()));
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
