using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumOfPositiveNumbers.UnitTests
{
    [TestClass]
    public class UnitTest
    {
        private Sum sum = new Sum();

        [TestMethod]
        public void PositiveSum_TotalFromInitializedArray()
        {
            int[] initializedArray = new int[] { 1, -1, 5, 4, -9, 8, -7, -6 };

            Assert.AreEqual(18, sum.PositiveSum(initializedArray));
        }

        [TestMethod]
        public void PositiveSum_TotalFromEmptyArray()
        {
            int[] emptyArray = new int[] { };

            Assert.AreEqual(0, sum.PositiveSum(emptyArray));
        }
    }
}
