using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZerosAndOnes.UnitTests
{
    [TestClass]
    public class ZerosAndOnesTests
    {
        ParseString ps = new ParseString();

        [TestMethod]
        public void ShortestString_Input_110100_Returns2()
        {
            Assert.AreEqual(2, ps.ShortestString("110100"));
        }

        [TestMethod]
        public void ShortestString_Input_01010_Returns1()
        {
            Assert.AreEqual(1, ps.ShortestString("01010"));
        }

        [TestMethod]
        public void ShortestString_Input_010101_Returns0()
        {
            Assert.AreEqual(0, ps.ShortestString("010101"));
        }

        [TestMethod]
        public void ShortestString_Input_1100010_Returns0()
        {
            Assert.AreEqual(3, ps.ShortestString("1100010"));
        }
    }
}
