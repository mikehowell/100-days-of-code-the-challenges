using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var convert = new Convert();
            Console.WriteLine(convert.ToCamelCase("the-stealth-warrior"));
            Console.WriteLine(convert.ToCamelCase("The_stealth_warrior"));
        }
    }
}
