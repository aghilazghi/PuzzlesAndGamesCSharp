using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndGamesLibrary;

namespace PuzzlesAndGames.Test
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void Test_IsOrdered_InputOrderedFirstSecondThirdFalse_ExpectedReturnsTrue()
        {
            var order = new Order();
            var actual = order.IsOrdered(1, 3, 4, false);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Test_IsOrdered_InputOrderedSecondThirdFirstFalse_ExpectedReturnsFalse()
        {
            var order = new Order();
            var actual = order.IsOrdered(1, 8, 4, false);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void Test_IsOrdered_InputOrderedSecondThirdFirstTrue_ExpectedReturnsTrue()
        {
            var order = new Order();
            var actual = order.IsOrdered(1, 0, 6, true);
            Assert.AreEqual(true, actual);
        }
    }
}
