using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace RandomNumbers.UnitTests
{
    [TestClass]
    public class GenerateRandomTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GenerateRandom_InvalidMinimumParameter_ThrowsException()
        {
            var rd = new GenerateRandom(-1, 1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GenerateRandom_InvalidMaximumParameter_ThrowsException()
        {
            var rd = new GenerateRandom(1, -1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GenerateRandom_InvalidNumberOfRandomNumbersParameter_ThrowsException()
        {
            var rd = new GenerateRandom(1, 10, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GenerateRandom_InvalidRangeOfNumberOfRandomNumbersParameter_ThrowsException()
        {
            var rd = new GenerateRandom(1, 10, 20);
        }

        [TestMethod]
        public void GenerateRandom_CorrectNumberOfRandomNumbersGenerated()
        {
            var rd = new GenerateRandom(1, 10, 4);
            List<int> rdList = rd.RandomNumberList();

            Assert.IsTrue(rdList.Count == 4);
        }

        [TestMethod]
        public void GenerateRandom_AllRandomNumbersAreDifferent()
        {
            var rd = new GenerateRandom(1, 10, 4);
            List<int> rdList = rd.RandomNumberList();

            Assert.IsTrue(rdList[0] != rdList[1] && rdList[0] != rdList[2] && rdList[0] != rdList[3] && rdList[1] != rdList[2] && rdList[1] != rdList[3] && rdList[2] != rdList[3]);
        }
    }
}
