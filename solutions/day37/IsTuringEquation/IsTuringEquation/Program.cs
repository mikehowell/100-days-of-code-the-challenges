using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTuringEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            var tt = new TuringTest();
            Console.WriteLine(tt.IsTurning("73+42=16"));
        }
    }
}
