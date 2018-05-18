using System;
using System.Collections.Generic;

namespace RandomNumbers
{
    public class GenerateRandom
    {
        public int Min { get; private set; }
        public int Max { get; private set; }
        public int NumberOfRandomNumbers { get; private set; }

        public GenerateRandom(int minimum, int maximum, int numberOfRandomNumbers)
        {
            try
            {
                if (minimum >= 0 && Max >= 0 && (numberOfRandomNumbers > 0 && numberOfRandomNumbers <= maximum + 1 - minimum))
                {
                    this.Min = minimum;
                    this.Max = maximum;
                    this.NumberOfRandomNumbers = numberOfRandomNumbers;

                }
                else
                {
                    throw new ArgumentException("Input parameters should be greater than zero and the number of random numbers to generate should be less than or equal to the range between minimum and maximum");
                }
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        public List<int> RandomNumberList()
        {
            List<int> randomResults = new List<int>();

            var random = new Random();

            for (int i = 0; i < this.NumberOfRandomNumbers; i++)
            {
                int number = random.Next(this.Min, this.Max + 1);
                if (!randomResults.Contains(number))
                {
                    randomResults.Add(number);
                }
                else
                {
                    i--;
                }
            }

            return randomResults;
        }
    }
}
