using System;
using System.Collections.Generic;

namespace ChangeReturn
{
    public class ChangeReturn
    {
        //public Change[] GetChange(decimal cost, decimal paid)
        public List<Change> GetChange(decimal cost, decimal paid)

        {
            var changeArray = new List<Change>();
            decimal change = paid - cost;

            if (change == 0)
            {
                return changeArray;
            }
            else
            {
                int dollarComponent = (int)change;
                int centComponet = (int)((change - (decimal)dollarComponent) * 100);
                
                //100
                var numberOf100Dollars = (dollarComponent - (dollarComponent % 100))/100;
                if (numberOf100Dollars != 0)
                {
                    changeArray.Add(new Change() { Denomination = Denomination.HundredDollar, Number = numberOf100Dollars });
                }

                //50
                var numberOf50Dollars = (dollarComponent - (numberOf100Dollars * 100)) % 50;

                //20

                //10

                //5

                //1
                return changeArray;
            }


            
        }
    }
}
