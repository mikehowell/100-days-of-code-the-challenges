using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeReturn
{

    class Program
    {
        static void Main(string[] args)
        {
            var cr = new ChangeReturn();

            foreach (var item in cr.GetChange((decimal)1.95, (decimal)5.00))
            {
                Console.WriteLine(item.Denomination + " " + item.Number);
            }
            
        }
    }
}
