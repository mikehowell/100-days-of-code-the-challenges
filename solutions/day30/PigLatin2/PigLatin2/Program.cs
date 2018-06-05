using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace PigLatin2
{
    class Program
    {
        static void Main(string[] args)
        {
            var etpl = new PigLatin();
            Console.WriteLine(etpl.PigLatinToEnglish("iway"));
            Console.WriteLine(etpl.PigLatinToEnglish("ellohay"));
            Console.WriteLine(etpl.PigLatinToEnglish("oveglay"));

            
        }
    }
}
