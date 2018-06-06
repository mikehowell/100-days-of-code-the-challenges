using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new CaesarCipher();
            Console.WriteLine(cc.Encode("Hello, World!", 4));
            Console.ReadLine();


        }
    }
}
