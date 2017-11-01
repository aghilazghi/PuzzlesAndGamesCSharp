using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndGamesLibrary;

namespace PuzzlesAndGames.Test
{
    [TestClass]
    public class PartialSumTest
    {
        [TestMethod]
        public void Test_Sum_FirstParamEq13_ExpectedZeroReturnsZero()
        {
            var partial = new PartialSum();
            var expected = 0;
            var actual = partial.Sum(13, 2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Sum_SecondParamEq13_ExpectedFirstParamReturnsFirstParam()
        {
            var partial = new PartialSum();
            var expected = 9;
            var actual = partial.Sum(9, 13, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Sum_ThirdParamEq13_ExpectedSumOfFirstAndSecondParamsRseturnsSumOfFirstAndSecondParams()
        {
            var partial = new PartialSum();
            var expected = 23;
            var actual = partial.Sum(9, 14, 13);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Sum_AllParamsNotEq13_ExpectedSumOfAllParamsRseturnsSumOfAllParams()
        {
            var partial = new PartialSum();
            var expected = 23;
            var actual = partial.Sum(9, 14, 13);
            Assert.AreEqual(expected, actual);
        }
    }
}
