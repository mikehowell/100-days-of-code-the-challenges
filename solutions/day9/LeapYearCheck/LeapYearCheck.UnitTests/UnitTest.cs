using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeapYearCheck.UnitTests
{
    [TestClass]
    public class UnitTest
    {
        LeapYearCheck lyc = new LeapYearCheck();
        string expectedResult_NotLeapYear = "Not Leap";
        string expectedResult_LeapYear = "Leap";

        [TestMethod]
        public void NotLeapYear_IsLeapYearCheck_False()
        {
            int notALeapYear = 1975;
            Assert.AreEqual(expectedResult_NotLeapYear, lyc.IsLeapYear(notALeapYear));
        }

        [TestMethod]
        public void LeapYearDivisibleBy4_IsLeapYearCheck_True()
        {
            int leapYear = 2008;
            Assert.AreEqual(expectedResult_LeapYear, lyc.IsLeapYear(leapYear));
        }

        [TestMethod]
        public void NotLeapYearDivisibleBy4And100_IsLeapYearCheck_False()
        {
            int notALeapYear = 2100;
            Assert.AreEqual(expectedResult_NotLeapYear, lyc.IsLeapYear(notALeapYear));
        }

        [TestMethod]
        public void LeapYearDivisibleBy4And100And400_IsLeapYearCheck_True()
        {
            int leapYear = 2000;
            Assert.AreEqual(expectedResult_LeapYear, lyc.IsLeapYear(leapYear));
        }
    }
}
