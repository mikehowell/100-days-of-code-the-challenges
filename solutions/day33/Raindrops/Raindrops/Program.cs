using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            var rd = new Raindrops();
            Console.WriteLine(rd.Convert(2));
            Console.WriteLine(rd.Convert(6));
            Console.WriteLine(rd.Convert(10));
            Console.WriteLine(rd.Convert(15));
            Console.WriteLine(rd.Convert(14));
        }
    }
}
