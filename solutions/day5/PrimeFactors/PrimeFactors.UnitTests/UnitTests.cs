using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PrimeFactors.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void PrimeFactors_GeneratePrimeFactorsFor_ValidResult()
        {
            int number = 369;
            var pf = new PrimeFactors();
            List<int> listOfPf = pf.GeneratePrimeFactorsFor(number);
            List<int> expected = new List<int>(new int[] { 3, 3, 41 });

            CollectionAssert.AreEqual(expected, listOfPf);

            //re-assign variables for a second test
            number = 287;
            listOfPf = pf.GeneratePrimeFactorsFor(number);
            expected = new List<int>(new int[] { 7, 41 });
            CollectionAssert.AreEqual(expected, listOfPf);
        }
    }
}
