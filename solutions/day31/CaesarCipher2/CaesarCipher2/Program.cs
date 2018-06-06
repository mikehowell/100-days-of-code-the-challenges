using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new CaesarCipher();
            Console.WriteLine(cc.Encode("Hello, World!", 4));
            Console.WriteLine(cc.Decode("Lipps, Asvph!", 4));

            Console.ReadLine();
        }
    }
}
