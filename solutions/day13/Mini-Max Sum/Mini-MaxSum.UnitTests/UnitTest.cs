using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MiniMax.UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void MiniMaxSum_MaxResult()
        {
            var input = new MiniMaxSum(5, 2, 3, 1, 4);
            var expectedMax = 14;
            Assert.AreEqual(expectedMax, input.MaxSum());

            input = new MiniMaxSum(7, 8, 5, 6, 4, 3, 1, 2);
            expectedMax = 35;
            Assert.AreEqual(expectedMax, input.MaxSum());

        }

        [TestMethod]
        public void MiniMaxSum_MinResult()
        {
            var input = new MiniMaxSum(5, 2, 3, 1, 4);
            var expectedMin = 10;
            Assert.AreEqual(expectedMin, input.MinSum());

            input = new MiniMaxSum(7, 8, 5, 6, 4, 3, 1, 2);
            expectedMin = 28;
            Assert.AreEqual(expectedMin, input.MinSum());
        }
    }
}
