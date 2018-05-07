using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StrongN.UnitTests
{
    [TestClass]
    public class UnitTest
    {
        private int validStrongNumber = 145;
        private int invalidStrongNumber = 150;
        
        [TestMethod]
        public void StrongNumber_IsStrongN_True()
        {
            var sn = new StrongNumber(validStrongNumber);
            Assert.IsTrue(sn.IsStrongN());
        }

        [TestMethod]
        public void StrongNumber_IsStrongN_False()
        {
            var isn = new StrongNumber(invalidStrongNumber);
            Assert.IsFalse(isn.IsStrongN());
        }
    }
}
