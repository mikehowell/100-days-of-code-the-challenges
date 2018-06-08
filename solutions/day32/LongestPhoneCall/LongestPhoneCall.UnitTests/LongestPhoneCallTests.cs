using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LongestPhoneCall.UnitTests
{
    [TestClass]
    public class LongestPhoneCallTests
    {
        [TestMethod]
        public void CallDuration_TwentyCentsCallCost312_CallDurationFourteenMinutes()
        {
            PhoneCall phoneCall = new PhoneCall(3,1,2,20);
            Assert.AreEqual(14, phoneCall.CallDuration());
        }

        [TestMethod]
        public void CallDuration_FiftySixCentsCallCost523_CallDurationTwentOneMinutes()
        {
            PhoneCall phoneCall = new PhoneCall(5, 2, 3, 55);
            Assert.AreEqual(21, phoneCall.CallDuration());
        }
    }
}
