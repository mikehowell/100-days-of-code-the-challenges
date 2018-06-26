using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeightedUniformSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            UniformSubstringProcessor usp = new UniformSubstringProcessor();

            string[] result = usp.weightedUniformStrings("abccddde", new int[] { 1, 3, 12, 5, 9, 10 });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
