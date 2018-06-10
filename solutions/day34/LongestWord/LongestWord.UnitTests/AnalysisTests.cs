using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LongestWord.UnitTests
{
    [TestClass]
    public class AnalysisTests
    {
        [TestMethod]
        public void LongestWord_WithInputOf_I_Love_Cats_Returns_Love()
        {
            var analysis = new Analysis();
            Assert.AreEqual("love", analysis.LongestsWord("I love cats!"));
        }

        [TestMethod]
        public void LongestWord_WithInputOf_fun_time_Returns_time()
        {
            var analysis = new Analysis();
            Assert.AreEqual("time", analysis.LongestsWord("fun&!! time"));
        }
    }
}
