using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsTuringEquation.UnitTests
{
    [TestClass]
    public class TuringTestTests
    {
        TuringTest tt = new TuringTest();
        [TestMethod]
        public void IsTuring_Input_73plus42equals16_Returns_True()
        {
            Assert.IsTrue(tt.IsTurning("73+42=16"));
        }

        [TestMethod]
        public void IsTuring_Input_5plus8equals13_Returns_False()
        {
            Assert.IsFalse(tt.IsTurning("5+8=13"));
        }
    }
}
