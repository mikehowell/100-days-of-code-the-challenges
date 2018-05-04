using System;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\r\nPrime factors for {0} are:", enteredNumber);
            PrimeFactors pf = new PrimeFactors();

            foreach (var value in pf.GeneratePrimeFactorsFor(enteredNumber))
            {
                Console.WriteLine(value);
            }
        }
    }
}

