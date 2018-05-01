using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sampler = new ProduceSample();
            var resultArray = sampler.ReturnSample(4, 10);
            var resultString = String.Empty;

            foreach (var number in resultArray)
            {
                resultString += (number.ToString() + " ");
            }
            Console.WriteLine(resultString);
        }
    }
}
