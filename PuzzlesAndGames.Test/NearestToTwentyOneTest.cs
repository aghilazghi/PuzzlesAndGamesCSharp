using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndGamesLibrary;

namespace PuzzlesAndGames.Test
{
    [TestClass]
    public class NearestToTwentyOneTest
    {
        [TestMethod]
        public void Test_Near_InputFirstLtSecondLtEq21_ExpectedSecondReturnsSecond()
        {
            var tewnetyOne = new NearestToTwentyOne();
            var expected = 21;
            var actual = tewnetyOne.Near(18, 21);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Near_InputSecondLtFirstLtEq21_ExpectedFirstReturnsFirst()
        {
            var tewnetyOne = new NearestToTwentyOne();
            var expected = 21;
            var actual = tewnetyOne.Near(21, 17);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Near_InputFirstLt21SecondGt21_ExpectedFirstReturnsFirst()
        {
            var tewnetyOne = new NearestToTwentyOne();
            var expected = 16;
            var actual = tewnetyOne.Near(16, 22);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Near_InputSecondLt21FirstGt21_ExpectedSecondReturnsSecond()
        {
            var tewnetyOne = new NearestToTwentyOne();
            var expected = 17;
            var actual = tewnetyOne.Near(22, 17);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Near_InputSecondAndFirstGt21_ExpectedZeroReturnsZero()
        {
            var tewnetyOne = new NearestToTwentyOne();
            var expected = 0;
            var actual = tewnetyOne.Near(22, 50);
            Assert.AreEqual(expected, actual);
        }
    }
}
