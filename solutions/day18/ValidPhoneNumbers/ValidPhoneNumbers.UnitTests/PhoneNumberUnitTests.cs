using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidPhoneNumbers.UnitTests
{
    [TestClass]
    public class PhoneNumberUnitTests
    {
        PhoneNumber pn = new PhoneNumber();

        [TestMethod]
        public void IsValid_ProvideValidPhoneNumber_ReturnsTrue()
        {
            Assert.IsTrue(pn.IsValid("(123) 456-7890"));            
        }

        [TestMethod]
        public void IsValid_ProvideInvalidPhoneNumber_ReturnsFalse()
        {
            Assert.IsFalse(pn.IsValid("(1111)555 2345"));
            Assert.IsFalse(pn.IsValid("(098) 123 4567"));
        }
    }
}
