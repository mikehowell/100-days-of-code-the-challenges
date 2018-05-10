using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DivisibilityByThirteen.UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void DivisibilityByThirteen_Thirt_Result()
        {
            var thirteen = new Thirteen();

            Assert.AreEqual(87, thirteen.Thirt(1234567));
            Assert.AreEqual(48, thirteen.Thirt(48));
        }
    }
}
