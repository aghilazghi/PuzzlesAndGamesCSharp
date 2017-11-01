using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndGamesLibrary;

namespace PuzzlesAndGames.Test
{
    [TestClass]
    public class SumUniqueTest
    {
        [TestMethod]
        public void Test_Sum_InputUniqueArguments_ExpectedTheSumOfThreeParams()
        {
            var unique = new SumUnique();
            var expected = 6;
            var actual = unique.Sum(1, 2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Sum_InputTheFirstTwoParamsAreEqual_ExpectedReturnsTheThirdParamValue()
        {
            var unique = new SumUnique();
            var expected = 3;
            var actual = unique.Sum(-1, -1, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Sum_InputTheFirstAreThirdParamsAreEqual_ExpectedReturnsTheSecondParamValue()
        {
            var unique = new SumUnique();
            var expected = -1;
            var actual = unique.Sum(3, -1, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Sum_InputTheSecondAreThirdParamsAreEqual_ExpectedReturnsTheFirstdParamValue(){
            var unique = new SumUnique();
            var expected = -1;
            var actual = unique.Sum(3, -1, 3);
            Assert.AreEqual(expected, actual);
        }
    }
}
