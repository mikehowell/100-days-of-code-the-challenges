using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradingStudents;
using System.Collections.Generic;

namespace GradingStudents.UnitTests
{
    [TestClass]
    public class GradingUnitTests
    {
        Grading grading = new Grading();

        [TestMethod]
        public void RoundGrades_ValidGrades_ReturnsCorrectRounding()
        {
            var gradingList = grading.RoundGrades(4, 73, 67, 38, 33);
            var expectedList = new List<int> { 75, 67, 40, 33 };

            CollectionAssert.AreEqual(expectedList, gradingList);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RoundGrades_InvalidGrades_ThrowException()
        {
            var gradingList = grading.RoundGrades(2, 101);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RoundGrades_InvalidNumberOfStudens_ThrowException()
        {
            var gradingList = grading.RoundGrades(61, 10, 10, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RoundGrades_InvalidNumberOfParameters_ThrowException()
        {
            var gradingList = grading.RoundGrades(1);
        }
    }
}
