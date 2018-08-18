using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTest
{
    [TestClass]
    public class BirthdayCakeCandlesTest
    {
        [TestMethod]
        public void Get2Candles()
        {
            long[] arr = { 1, 3, 2, 3 };
            Assert.AreEqual("2", ReturnCountCandles(arr));
        }

        private string ReturnCountCandles(long[] arr)
        {
            return BirthdayCakeCandles.GetBirthdayCakeCandles(arr);
        }
    }
}
