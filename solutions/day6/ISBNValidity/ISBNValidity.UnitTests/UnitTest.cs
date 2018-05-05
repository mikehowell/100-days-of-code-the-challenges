using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISBNValidity.UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ISBN_IsValid_True()
        {
            var isbn = new ISBN();
            var validISBN = "0201314525";

            Assert.IsTrue(isbn.IsValid(validISBN));
        }

        [TestMethod]
        public void ISBN_IsValid_False()
        {
            var isbn = new ISBN();
            var invalidISBN = "0201314535";

            Assert.IsFalse(isbn.IsValid(invalidISBN));
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ISBN_IsValid_GenerateException()
        {
            var isbn = new ISBN();
            var shortISBN = "02013145";

            isbn.IsValid(shortISBN);
        }
    }
}
