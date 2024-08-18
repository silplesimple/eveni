using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dul.Tests
{
    [TestClass]
    public class StringLibraryTest
    {
        [TestMethod]
        public void CutStringTest()
        {
            var expected = "안녕하...";

            var actual = "안녕하세요.".CutStringUnicode(6);

            Assert.AreEqual(expected, actual);
        }
    }
}