using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var analyse = new Analysis();
            Console.WriteLine(analyse.LongestsWord("I love cats!"));
        }
    }
}
