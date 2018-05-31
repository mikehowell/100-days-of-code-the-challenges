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
            decimal remaining = change;

            if (change == 0)
            {
                return changeArray;
            }
            else
            {
                //how many $100 change
                int hundredDollar = (int)(remaining / 100);
                if (hundredDollar != 0)
                {
                    changeArray.Add(new Change() { Denomination = Denomination.HundredDollar, Number = hundredDollar });
                }

                //how many $50 change
                remaining = remaining - (100 * hundredDollar);
                int fiftyDollar = (int)(remaining / 50);
                if (fiftyDollar != 0)
                {
                    changeArray.Add(new Change() { Denomination = Denomination.FiftyDollar, Number = fiftyDollar });
                }

                //how many $20 change
                remaining = remaining - (50 * fiftyDollar);
                int twentyDollar = (int)(remaining / 20);
                if (twentyDollar != 0)
                {
                    changeArray.Add(new Change() { Denomination = Denomination.TwentyDollar, Number = twentyDollar });
                }

                //how many $10 change
                remaining = remaining - (20 * twentyDollar);
                int tenDollar = (int)(remaining / 10);
                if (tenDollar != 0)
                {
                    changeArray.Add(new Change() { Denomination = Denomination.TenDollar, Number = tenDollar });
                }

                //how many $5 change
                remaining = remaining - (10 * tenDollar);
                int fiveDollar = (int)(remaining / 5);
                if (fiveDollar != 0)
                {
                    changeArray.Add(new Change() { Denomination = Denomination.FiveDollar, Number = fiveDollar });
                }

                //how many $1 change
                remaining = remaining - (5 * fiveDollar);
                int oneDollar = (int)(remaining / 1);
                if (oneDollar != 0)
                {
                    changeArray.Add(new Change() { Denomination = Denomination.OneDollar, Number = oneDollar });
                }

                //how many 50c change
                remaining = (remaining - (1 * oneDollar)) * 100;
                int halfDollar = (int)(remaining / 50);
                if (halfDollar != 0)
                {
                    changeArray.Add(new Change() { Denomination = Denomination.HalfDollar, Number = halfDollar });
                }

                //how many 25c change
                remaining = remaining - (50 * halfDollar);
                int quarter = (int)(remaining / 25);
                if (quarter != 0)
                {
                    changeArray.Add(new Change() { Denomination = Denomination.Quarter, Number = quarter });
                }

                //how many 10c change
                remaining = remaining - (25 * quarter);
                int dime = (int)(remaining / 10);
                if (dime != 0)
                {
                    changeArray.Add(new Change() { Denomination = Denomination.Dime, Number = dime });
                }

                //how many 5c change
                remaining = remaining - (10 * dime);
                int nickel = (int)(remaining / 5);
                if (nickel != 0)
                {
                    changeArray.Add(new Change() { Denomination = Denomination.Nickel, Number = nickel });
                }

                //how many 1c change
                remaining = remaining - (5 * nickel);
                int cent = (int)(remaining / 1);
                if (cent != 0)
                {
                    changeArray.Add(new Change() { Denomination = Denomination.Cent, Number = cent });
                }

                return changeArray;
            }


            
        }
    }
}
