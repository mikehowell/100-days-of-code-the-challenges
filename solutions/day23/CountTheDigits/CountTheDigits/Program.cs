using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dc = new DigitCounter(10, 1);
                Console.WriteLine(dc.nb_dig());
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred: {0}", e.Message);
            }

        }
    }
}
