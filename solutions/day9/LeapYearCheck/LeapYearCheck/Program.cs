using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var lyc = new LeapYearCheck();
            Console.WriteLine(lyc.IsLeapYear(2009)); //not leap year
            Console.WriteLine(lyc.IsLeapYear(2012)); //leap year divisible by 4
            Console.WriteLine(lyc.IsLeapYear(2008)); //leap year divisible by 4
            Console.WriteLine(lyc.IsLeapYear(2100)); //not leap year divisible by 4 but not 100
            Console.WriteLine(lyc.IsLeapYear(2000)); //leap year divisible by 4, 100 and 400
        }
    }
}
