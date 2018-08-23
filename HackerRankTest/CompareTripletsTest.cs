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
    public class CompareTripletsTest
    {
        [TestMethod]
        public void GetTriplets1e1()
        {
            Assert.AreEqual("1-1", ReturnTriplets(5, 6, 7, 3, 6, 10));
        }

        [TestMethod]
        public void GetTriplets2e1()
        {
            Assert.AreEqual("2-1", ReturnTriplets(17, 28, 30, 99, 16, 8));
        }

        [TestMethod]
        public void GetTriplets3e0()
        {
            Assert.AreEqual("3-0", ReturnTriplets(10, 15, 20, 5, 6, 7));
        }

        [TestMethod]
        public void GetTriplets0e1()
        {
            Assert.AreEqual("0-1", ReturnTriplets(20, 20, 30, 20, 20, 50));
        }

        private string ReturnTriplets(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            return CompareTriplets.GetCompareTriplets(a0, a1, a2, b0, b1, b2);
        }
    }
}
