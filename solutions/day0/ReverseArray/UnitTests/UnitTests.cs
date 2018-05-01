using System;
using Day0;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ArrayInput_PositivePath_ArrayReversed()
        {
            var input = "1,2,3,5";
            var inputArray = input.Split(',');
            var expectedOutput = "5 3 2 1";

            var reverseInput = new Reverse();

            Assert.IsTrue(reverseInput.ArrayInput(inputArray) == expectedOutput);
        }
    }
}
