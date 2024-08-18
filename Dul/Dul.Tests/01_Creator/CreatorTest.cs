using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dul.Tests
{
    [TestClass]
    public class CeratorTest
    {
        [TestMethod]
        public void CreatorTest()
        {
            //1 Arrange(정렬),Setup
            const string expected = "RedPlus";

            var actual = Creator.GetName();

            Assert.AreEqual(expected, actual);
        }
    }

}
