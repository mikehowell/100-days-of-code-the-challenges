using System.Collections.Generic;

namespace PrimeFactors
{
    public class PrimeFactors
    {
        public List<int> GeneratePrimeFactorsFor(int number)
        {
            var primeFactors = new List<int>();

            for (int divisor = 2; divisor <= number; divisor++)
            {
                while (number % divisor == 0)
                {
                    primeFactors.Add(divisor);
                    number = number / divisor;
                }
            }
            return primeFactors;
        }
    }
}

