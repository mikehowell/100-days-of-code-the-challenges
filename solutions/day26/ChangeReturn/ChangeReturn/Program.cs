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
            //var cr = new ChangeReturn();
            //Console.WriteLine(cr.GetChange(500, 600));

            decimal d = (decimal)186.91;
            int dollar = (int)d;
            Console.WriteLine(dollar);
            
            int cent = (int)((d - (decimal)dollar) * 100);
            Console.WriteLine(cent);

            var numberOf100Dollars = (dollar-(dollar % 100))/100;
            //var change = new Change() {Denomination = Denomination.HundredDollar, Number = numberOf100Dollars};

            var numberOf50Dollars = (dollar - (numberOf100Dollars * 100)) % 50;
            Console.WriteLine(numberOf50Dollars);


        }
    }
}
