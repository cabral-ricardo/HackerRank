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
    public class CircularArrayRotationTest
    {
        [TestMethod]
        public void GetArrayRotation5And3()
        {
            var res = CircularArrayRotation.ShiftRight(new[] { 3, 4, 5,}, 2).ToArray();
            var arrayFormat = String.Format("{0}-{1}", res[1], res[2]);
            Assert.AreEqual("5-3", arrayFormat);
        }
        
        [TestMethod]
        public void Rotate2()
        {
            var res = CircularArrayRotation.ShiftRight(new[] { 1, 2, 3, 4, 5, 6 }, 2).ToArray();
            Assert.IsTrue(res.SequenceEqual(new[] { 5, 6, 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void GetArrayRotation3And4()
        {
            var res = CircularArrayRotation.ShiftRightIntArray(new[] { 3, 4, 5, }, 1).ToArray();
            var arrayFormat = String.Format("{0}-{1}", res[1], res[2]);
            Assert.AreEqual("3-4", arrayFormat);
        }

        [TestMethod]
        public void GetArrayRotation3And1()
        {
            var res = CircularArrayRotation.ShiftRightIntArray(new[] { 1, 2, 3 }, 2).ToArray();
            var arrayFormat = String.Format("{0}-{1}", res[1], res[2]);
            Assert.AreEqual("3-1", arrayFormat);
        }

        [TestMethod]
        public void GetArrayRotation72722And90286()
        {
            var res = CircularArrayRotation.ShiftRightIntArray(new[] { 39356, 87674, 16667, 54260, 43958, 70429, 53682, 6169, 87496, 66190, 90286, 4912, 44792, 65142,
                36183, 43856, 77633, 38902, 1407, 88185, 80399, 72940, 97555, 23941, 96271, 49288, 27021, 32032, 75662, 69161, 33581, 15017, 56835, 66599, 69277, 17144,
                37027, 39310, 23312, 24523, 5499, 13597, 45786, 66642, 95090, 98320, 26849, 72722, 37221, 28255, 60906 }, 51).ToArray();

            var arrayFormat = String.Format("{0}-{1}", res[47], res[10]);
            Assert.AreEqual("72722-90286", arrayFormat);
        }


        [TestMethod]
        public void GetArrayRotation17144And16667()
        {
            var a = new[] { 39356, 87674, 16667, 54260, 43958, 70429, 53682, 6169, 87496, 66190, 90286, 4912, 44792, 65142,
                36183, 43856, 77633, 38902, 1407, 88185, 80399, 72940, 97555, 23941, 96271, 49288, 27021, 32032, 75662, 69161, 33581, 15017, 56835, 66599, 69277, 17144,
                37027, 39310, 23312, 24523, 5499, 13597, 45786, 66642, 95090, 98320, 26849, 72722, 37221, 28255, 60906 };

            var queries = new[] { 47, 10, 12,13,6 ,29,22,17,7 ,3 ,30,45,1 ,21,50,17,25,42,5 ,6 ,47,2 ,24,1 ,6 ,14,24,43,7 ,2 ,35,3 ,13,22,16,19,0 ,12,10,32,41,14,1 ,42,
                35,0 ,9 ,34,17,14,15,38,17,13,40,48,27,38,41,8 ,14,25,11,27,47,2 ,20,22,39,4 ,28,29,43,29,21,1 ,4 ,4 ,10,46,43,50,33,34,12,47,32,13,8 ,47,22,23,21,33,24,
                43,35,19,39,24 };

            var res = CircularArrayRotation.GetCircularArrayRotation(a, 51, queries);

            var arrayFormat = String.Format("{0}-{1}", res[30], res[21]);
            Assert.AreEqual("17144-16667", arrayFormat);
        }
    }
}
