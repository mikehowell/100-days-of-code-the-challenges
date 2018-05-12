using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertToCamelCase.UnitTests
{
    [TestClass]
    public class UnitTest
    {
        private readonly Convert c = new Convert();

        [TestMethod]
        public void Convert_ToCamelCase_Result()
        {
            var variableName = "the-stealth-warrior";
            var expectedResult = "theStealthWarrior";
            Assert.AreEqual(expectedResult, c.ToCamelCase(variableName));

            variableName = "The_Stealth_Warrior";
            expectedResult = "TheStealthWarrior";
            Assert.AreEqual(expectedResult, c.ToCamelCase(variableName));
        }
    }
}
