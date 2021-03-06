﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class TimeConversion
    {
        /// <summary>
        /// Convert string of parameter to default value AM or PM
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetTimeConversion(string s)
        {
            DateTime dt = Convert.ToDateTime(s);
            return String.Format("{0}", dt.ToString("HH:mm:ss"));
        }
    }
}
