using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompleteThePattern.UnitTests
{
    [TestClass]
    public class PatternCompletionTests
    {
        [TestMethod]
        public void Pattern_ProvideIntInput_ReturnsValidPattern()
        {
            var pc = new PatternCompletion();
            string expectedResult = "1\r\n22\r\n333\r\n4444\r\n55555\r\n";

            Assert.AreEqual(expectedResult, pc.Pattern(5));
        }
    }
}
