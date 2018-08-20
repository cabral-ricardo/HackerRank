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

        [TestMethod]
        public void Get4Candles()
        {
            long[] arr = { 10, 82, 49, 82, 82, 41, 82, 15, 63, 38, 25 };
            Assert.AreEqual("4", ReturnCountCandles(arr));
        }

        [TestMethod]
        public void Get5Candles()
        {
            long[] arr = { 10, 18, 90, 90, 13, 90, 75, 90, 8, 90, 43 };
            Assert.AreEqual("5", ReturnCountCandles(arr));
        }

        private string ReturnCountCandles(long[] arr)
        {
            return BirthdayCakeCandles.GetBirthdayCakeCandles(arr);
        }
    }
}
