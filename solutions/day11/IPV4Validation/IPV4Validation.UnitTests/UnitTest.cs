using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IPV4Validation.UnitTests
{
    [TestClass]
    public class UnitTest
    {
        private Validator v = new Validator();

        [TestMethod]
        public void IPV4Validtor_IsValid_True()
        {
            Assert.IsTrue(v.isValid("1.2.3.4"));
            Assert.IsTrue(v.isValid("123.45.67.89"));
            Assert.IsTrue(v.isValid("12.255.56.1"));
        }

        [TestMethod]
        public void IPV4Validtor_IsValid_False()
        {
            Assert.IsFalse(v.isValid("1.2.3"));
            Assert.IsFalse(v.isValid("1.2.3.4.5"));
            Assert.IsFalse(v.isValid("123.456.78.90"));
            Assert.IsFalse(v.isValid("123.045.067.089"));
        }
    }
}
