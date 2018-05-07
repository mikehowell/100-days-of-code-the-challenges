using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongN
{
    class Program
    {
        static void Main(string[] args)
        {
            var sn = new StrongNumber(145);
            Console.WriteLine(sn.IsStrongN().ToString());
        }
    }
}
