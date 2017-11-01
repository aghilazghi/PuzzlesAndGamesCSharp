using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndGamesLibrary;

namespace PuzzlesAndGames.Test
{
    [TestClass]
    public class CoolTest
    {
        [TestMethod]
        public void Test_IsCool_InputMultipleOfEleven_ExpectedReturnTrue()
        {
            var cool = new Cool();
            var actual = cool.IsCool(22);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Test_IsCool_InputNotMultipleOfEleven_ExpectedReturnFalse()
        {
            var cool = new Cool();
            var actual = cool.IsCool(-21);
            Assert.AreEqual(false, actual);
        }
    }
}
