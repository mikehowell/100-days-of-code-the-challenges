using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day1;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class Day1_UnitTest
    {
        [TestMethod]
        public void ProduceSample_ReturnSample_TestMethod1()
        {
            var sampler = new ProduceSample();
            var resultArray = sampler.ReturnSample(4, 10);
            var expectedResult = new List<int> { 9, 8, 7, 6 };

            Assert.IsTrue(resultArray == expectedResult);
        }
    }
}
