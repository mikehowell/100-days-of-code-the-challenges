using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPositiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, -1, 5, 4, -9, 8, -7, -6 };
            var sum = new Sum();

            Console.WriteLine(sum.PositiveSum(numbers).ToString());
        }
    }
}
