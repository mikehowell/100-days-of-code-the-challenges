using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin1
{
    class Program
    {
        static void Main(string[] args)
        {
            var plt = new PigLatin();
            Console.WriteLine(plt.EnglishToPigLatin("Hello, World."));
            Console.WriteLine(plt.EnglishToPigLatin("About"));
            Console.WriteLine(plt.EnglishToPigLatin("The"));
            Console.ReadLine();

        }
    }
}
