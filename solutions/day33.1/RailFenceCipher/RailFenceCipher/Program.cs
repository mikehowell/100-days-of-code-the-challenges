using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailFenceCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var RFC = new RFCipher();
            Console.WriteLine(RFC.Encode("We Are Discovered Flee At Once", 4));

            Console.WriteLine(RFC.Decode("W VFTEEDOE LA E RICRDE OCASEEN", 4));
            Console.ReadLine();
        }
    }
}
