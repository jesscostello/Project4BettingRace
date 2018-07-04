using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project4BettingRace;
using Project4BettingRace.Business;

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

        [TestMethod]
        public void TestValuesFromInstantiation()
        {
            Punter[] myPunter = new Punter[3];
            int Id = 1;
            string name = "Farmer Brown";
            myPunter[1] = Factory.GetAPunter(Id);

            Assert.AreEqual(name, myPunter[1].PunterName);
        }
    }
}
