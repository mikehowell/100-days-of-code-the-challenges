using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeightedUniformSubstring.UnitTests
{
    [TestClass]
    public class UniformSubstringProcessorTests
    {
        UniformSubstringProcessor usp;

        [TestInitialize]
        public void Initialize()
        {
            usp = new UniformSubstringProcessor();
        }

        [TestMethod]
        public void weightedUniformStrings_Input_abccddde_ExpectedOutput_YesYesYesYesNoNO()
        {
            string[] result = usp.weightedUniformStrings("abccddde", new int[] { 1, 3, 12, 5, 9, 10 });
            string[] expected = new string[] { "YES", "YES", "YES", "YES", "NO", "NO" };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
