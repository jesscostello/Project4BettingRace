using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRandomNumber()
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 5);

            Assert.IsTrue(result >= 1 && result <= 5);
        }

        [TestMethod]
        public void TestLargeNumber()
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 5);

            Assert.IsFalse(result > 5);
        }
    }
}
