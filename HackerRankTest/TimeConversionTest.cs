using HackerRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HackerRankTest
{
    [TestClass]
    public class TimeConversionTest
    {
        [TestMethod]
        public void Format190545()
        {
            Assert.AreEqual("19:05:45", FormatTimeConversion("07:05:45PM"));
        }

        [TestMethod]
        public void Format124022()
        {
            Assert.AreEqual("00:40:22", FormatTimeConversion("12:40:22AM"));
        }

        [TestMethod]
        public void Format064003()
        {
            Assert.AreEqual("06:40:03", FormatTimeConversion("06:40:03AM"));
        }

        [TestMethod]
        public void Format235959()
        {
            Assert.AreEqual("23:59:59", FormatTimeConversion("11:59:59PM"));
        }

        [TestMethod]
        public void Format000000()
        {
            Assert.AreEqual("00:00:00", FormatTimeConversion("12:00:00AM"));
        }

        [TestMethod]
        public void Format045959()
        {
            Assert.AreEqual("16:59:59", FormatTimeConversion("04:59:59PM"));
        }

        private string FormatTimeConversion(string s)
        {
            return TimeConversion.GetTimeConversion(s);
        }
    }
}
