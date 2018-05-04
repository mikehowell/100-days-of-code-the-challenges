using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianRupeeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            var format = new Format();
            Console.WriteLine(format.ReturnIndianRupee(1234));
        }
    }
}
