using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HackerRank;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTest
{
    [TestClass]
    public class VeryBigSumTest
    {
        [TestMethod]
        public void SumArray4()
        {
            long[] ar = {1, 3};

            Assert.AreEqual("4", SumArray(ar));
        }

        [TestMethod]
        public void SumArray5000000020()
        {
            long[] ar = { 5, 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

            Assert.AreEqual("5000000020", SumArray(ar));
        }

        [TestMethod]
        public void SumArray10047338136()
        {
            long[] ar = { 10, 1001458909, 1004570889, 1007019111, 1003302837, 1002514638, 1006431461, 1002575010, 1007514041, 1007548981, 1004402249 };

            Assert.AreEqual("10047338136", SumArray(ar));
        }

        private static string SumArray(long[] ar)
        {
            return VeryBigSum.GetVeryBigSum(ar).ToString();
        }
    }
}
