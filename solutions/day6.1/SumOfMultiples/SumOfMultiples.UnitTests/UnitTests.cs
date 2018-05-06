using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumOfMultiples.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void SumOfMultiple_CorrectAnswer()
        {
            var sumOfMultiples = new SumOfMultiples();

            Assert.AreEqual(233168, sumOfMultiples.Sum);
        }
    }
}
