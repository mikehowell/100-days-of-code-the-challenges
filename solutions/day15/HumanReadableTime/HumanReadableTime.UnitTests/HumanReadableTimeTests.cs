using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HumanReadableTime.UnitTests
{
    [TestClass]
    public class HumanReadableTimeTests
    {
        [TestMethod]
        public void ConvertToReadableTime_EnterValidTime_ReturnsReadableTime()
        {
            ReadableTime rt = new ReadableTime();

            Assert.AreEqual("99:59:59", rt.ConvertToReadableTime(359999));
            Assert.AreEqual("01:07:36", rt.ConvertToReadableTime(4056));
            Assert.AreEqual("05:17:27", rt.ConvertToReadableTime(19047));
            Assert.AreEqual("67:42:03", rt.ConvertToReadableTime(243723));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConvertToReadableTime_EnterInvalidTime_ReturnsException()
        {
            ReadableTime rt = new ReadableTime();
            rt.ConvertToReadableTime(360000);
        }
    }
}
