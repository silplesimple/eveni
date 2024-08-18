using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dul.Tests
{
    [TestClass]
    public class DateTimeUtilityTest
    {
        [TestMethod]
        public void ShowTimeOrDateTest()
        {
            var now = DateTime.Now;
            var expeted = now.ToString("hh:mm:ss");

            Assert.AreEqual(expeted, DateTimeUtility.ShowTimeOrDate(now));
        }

        [TestMethod]
        public void ShowTimeOrDateTestOther()
        {
            var prev = DateTime.Now.AddDays(-7);
            Console.WriteLine(DateTimeUtility.ShowTimeOrDate(prev));
            Console.WriteLine(DateTimeUtility.ShowTimeOrDate(prev, "yy-MM-dd"));
        }
    }
}
