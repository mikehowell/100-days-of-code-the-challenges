using System.Collections.Generic;
using System;

namespace GradingStudents
{
    public class Grading
    {
        private int _nextMultipleOfFive { get; set; }
        public List<int> RoundGrades(params int[] input)
        {
            if (!(input.Length >= 2))
            {
                throw new ArgumentOutOfRangeException("input", "Invalid number of input values\r\n \tFirst input should be number of students\r\n \tFollowed by the grades for each of the students");
            }
            var outputList = new List<int>();

            try
            {
                var inputList = new List<int>(input);

                if (inputList[0] < 1 || inputList[0] > 60)
                {
                    throw new ArgumentException("Number of students should be between 1 and 60 inclusive");
                }

                for (int i = 1; i < inputList.Count; i++)
                {
                    if (inputList[i] < 0 || inputList[i] > 100)
                    {
                        throw new ArgumentException("Grades should be between 0 and 100");
                    }
                    outputList.Add(Round(inputList[i]));
                }
            }
            catch (Exception)
            {
                throw;
            }
            

            return outputList;
        }

        private int Round(int grade)
        {
            if (grade < 38)
            {
                return grade;
            }

            _nextMultipleOfFive = NextMultipleOfFive(grade);

            if (_nextMultipleOfFive - grade < 3)
            {
                return _nextMultipleOfFive;
            }
            else
            {
                return grade;
            }
        }

        private int NextMultipleOfFive(int grade)
        {
            int nextMultiple = 0;

            if (grade % 5 == 0)
            {
                nextMultiple = grade;
            }

            while (grade % 5 != 0)
            {
                grade += 1;
                if (grade % 5 == 0)
                {
                    nextMultiple = grade;
                }
            }

            return nextMultiple;
        }
    }
}
