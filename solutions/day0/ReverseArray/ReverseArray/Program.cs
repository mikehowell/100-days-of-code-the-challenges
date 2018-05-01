using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array of numbers separated by commas \r\ne.g. 4,3,6,9,2");
            var input = Console.ReadLine().Trim();
            var inputArray = input.Split(',');

            var Reverse = new Reverse();

            Console.WriteLine(Reverse.ArrayInput(inputArray));
        }
    }
}
