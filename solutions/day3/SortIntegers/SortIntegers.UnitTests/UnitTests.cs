using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortIntegers.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsSortedIntgers_SortNumbers()
        {
            var unsortedList = new List<int>(new int[] { 3, 2, 1 });
            var sort = new Sort();
            var sortedList = sort.SortNumbers(unsortedList);

            var expectedList = new List<int>(new int[] { 1, 2, 3 });

            CollectionAssert.AreEqual(expectedList, sortedList);
        }
    }
}
