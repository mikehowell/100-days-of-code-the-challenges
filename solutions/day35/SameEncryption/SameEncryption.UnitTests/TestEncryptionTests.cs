using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SameEncryption.UnitTests
{
    [TestClass]
    public class TestEncryptionTests
    {
        [TestMethod]
        public void AreSame_Inputs_EbnhGfjklmjhgz_And_Eabcz_Returns_True()
        {
            var te = new TestEncryption();
            Assert.IsTrue(te.AreSame("EbnhGfjklmjhgz", "Eabcz"));
        }

        [TestMethod]
        public void AreSame_Inputs_EbnhGfjklmjhgerez_And_Eabcdefz_Returns_True()
        {
            var te = new TestEncryption();
            Assert.IsTrue(te.AreSame("EbnhGfjklmjhgerez", "Eabcdefz"));
        }

        [TestMethod]
        public void AreSame_Inputs_Ebnhz_And_Eabcy_Returns_False()
        {
            var te = new TestEncryption();
            Assert.IsFalse(te.AreSame("Ebnhz", "Eabcy"));
        }

        [TestMethod]
        public void AreSame_Inputs_EbnhGfjklmjhgz_And_Eabcdefz_Returns_False()
        {
            var te = new TestEncryption();
            Assert.IsFalse(te.AreSame("EbnhGfjklmjhgz", "Eabcdefz"));
        }
    }
}
