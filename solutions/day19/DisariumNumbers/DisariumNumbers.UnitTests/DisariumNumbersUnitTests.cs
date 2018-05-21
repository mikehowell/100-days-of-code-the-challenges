using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DisariumNumbers.UnitTests
{
    [TestClass]
    public class DisariumNumbersUnitTests
    {
        DisariumTest dt = new DisariumTest();

        [TestMethod]
        public void IsDisarium_TestDisariumNumber_ReturnTrue()
        {
            Assert.IsTrue(dt.IsDisarium(89));
            Assert.IsTrue(dt.IsDisarium(135));
            Assert.IsTrue(dt.IsDisarium(175));
            Assert.IsTrue(dt.IsDisarium(518));
            Assert.IsTrue(dt.IsDisarium(598));
        }

        [TestMethod]
        public void IsDisarium_TestNonDisariumNumber_ReturnFalse()
        {
            Assert.IsFalse(dt.IsDisarium(40));
            Assert.IsFalse(dt.IsDisarium(88));
            Assert.IsFalse(dt.IsDisarium(108));
        }
    }
}
