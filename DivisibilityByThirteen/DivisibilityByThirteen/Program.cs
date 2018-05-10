using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibilityByThirteen
{
    class Program
    {
        static void Main(string[] args)
        {
            var thirteen = new Thirteen();
            Console.WriteLine( thirteen.Thirt(1234567));
            Console.WriteLine(thirteen.Thirt(48));
        }
    }
}
