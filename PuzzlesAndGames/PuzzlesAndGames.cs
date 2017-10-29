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

        [TestMethod]
        public void Test_IsCool()
        {
            var actual = IsCool(22);
            Assert.AreEqual(true, actual);
        }

        /*A number is cool if it's a multiple of 11 or if is one more than 
         * a multiple of 11. Return true if the given number is cool.
         */
        public bool IsCool(int givenNumber)
        {
            if(givenNumber < 1)
            {
                throw new ArgumentException();
            }

            return (givenNumber % 11 == 0 || givenNumber % 11 == 1);
        }
            
        /*
         * Given three integers, if second is greater than first, and third is 
         * greater than second. However, with the exception that if the 
         * parameter "isOk" is true, second does not need to be greater than 
         * first but still better be less than third.
         */
        public bool IsOrdered(int first, int second, int third, bool isOk) => isOk ? (first < third && second < third) : (first < second && second < third);
    }
}
