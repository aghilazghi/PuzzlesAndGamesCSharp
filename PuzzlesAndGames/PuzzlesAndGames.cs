using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PuzzlesAndGames
{
    [TestClass]
    public class PuzzlesAndGames
    {
        [TestMethod]
        public void Test_IsOrdered()
        {
            var actual = IsOrdered(1, 3, 4, false);
            Assert.AreEqual(true, actual);
        }


        /*
         * Given three integers, first, second, and third return if second is greater 
         * than first, and third is greater than second. However, with the exception 
         * that if the parameter "isOk" is true, second does not need to be greater than 
         * first but still better be less than third.
         */
        public bool IsOrdered(int first, int second, int third, bool isOk) => isOk ? (first < third && second < third) : first < second && second < third;
    }
}
