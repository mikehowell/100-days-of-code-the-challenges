using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumbers
{

    class Program
    {
        static void Main(string[] args)
        {
            var fs = new FibonacciNumbers(1, 2, 4000000);
            Console.WriteLine(fs.SumOfEvenNumbersInSequence());
            
        }
    }
}
