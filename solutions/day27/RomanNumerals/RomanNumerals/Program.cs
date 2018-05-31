using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnc = new RomanNumerals();
            Console.WriteLine(rnc.ArabicToRomanNumeral(4999));

            Console.ReadLine();
        }
    }
}
