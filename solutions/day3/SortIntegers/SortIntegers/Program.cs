using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsortedNumbers = new List<int>();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter a whole number");
                var response = Convert.ToInt32(Console.ReadLine());
                unsortedNumbers.Add(response);
            }

            var sort = new Sort();
            var sortedList = sort.SortNumbers(unsortedNumbers);

            var stringOfSortedIntegers = String.Empty;
            foreach (var number in sortedList)
            {
                stringOfSortedIntegers = stringOfSortedIntegers + number.ToString() + " ";
            }

            Console.WriteLine(stringOfSortedIntegers);
        }
    }
}
