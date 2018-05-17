using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedString
{
    class Program
    {
        static void Main(string[] args)
        {
            var rd = new Reduce();

            Console.WriteLine(rd.ReduceString("aabbcc")); //should return empty string
            Console.WriteLine(rd.ReduceString("aaabccddd")); //does correctly return abd 
            Console.WriteLine(rd.ReduceString("baab")); //should return empty string
        }
    }
}
