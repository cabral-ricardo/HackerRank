using System;
using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTest
{
    [TestClass]
    public class MinMaxSumTest
    {
        // Sum Min - except the largest array number
        // Sum Max - except the less array number

        [TestMethod]
        public void Minimo10Maximo14()
        {
            long[] arr = { 5, 4, 3, 2, 1 };
            Assert.AreEqual("10-14", RetornarMinimoMaximo(arr));
        }

        [TestMethod]
        public void Minimo2063136757Maximo2744467344()
        {
            long[] arr = { 256741038, 623958417, 467905213, 714532089, 938071625 };
            Assert.AreEqual("2063136757-2744467344", RetornarMinimoMaximo(arr));
        }

        [TestMethod]
        public void Minimo299Maximo9271()
        {
            long[] arr = { 7, 69, 2, 221, 8974 };
            Assert.AreEqual("299-9271", RetornarMinimoMaximo(arr));
        }

        [TestMethod]
        public void Minimo20Maximo20()
        {
            long[] arr = { 5, 5, 5, 5, 5 };
            Assert.AreEqual("20-20", RetornarMinimoMaximo(arr));
        }

        private string RetornarMinimoMaximo(long[] arr)
        {
            return MinMaxSum.GetMinMaxSum(arr);
        }
    }
}
