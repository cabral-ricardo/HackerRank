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
            InicializeTimeConversion();
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
