using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvenFibonacciNumbers.UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void EvenFibonacciNumbers_SumOfEvenNumbersInSequence_ToFourMillion()
        {
            var fn = new FibonacciNumbers(1, 2, 4000000);
            long expected = 4613730;

            Assert.AreEqual(expected, fn.SumOfEvenNumbersInSequence());
        }
    }
}
