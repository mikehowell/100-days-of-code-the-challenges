using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IndianRupeeFormat.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Format_ReturnIndianRupee_CorrectOutput()
        {
            var format = new Format();
            int money = 12356;
            string expectedResult = "12Thousand 356";

            Assert.AreEqual(expectedResult, format.ReturnIndianRupee(money));
        }
    }
}
