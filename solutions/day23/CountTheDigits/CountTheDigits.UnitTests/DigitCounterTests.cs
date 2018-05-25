using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountTheDigits.UnitTests
{
    [TestClass]
    public class DigitCounterTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DigitCounter_InvalidContructornPassed_ThrowsException()
        {
            DigitCounter dc = new DigitCounter(-1, 1);   
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DigitCounter_InvalidContructordPassed_ThrowsException()
        {
            DigitCounter dc = new DigitCounter(25, 10);
        }

        [TestMethod]
        public void DigitCounter_ValidParametersPassed_ReturnCorrectDigitCount()
        {
            DigitCounter dc = new DigitCounter(25, 1);
            Assert.AreEqual(11, dc.nb_dig());
        }
    }
}
