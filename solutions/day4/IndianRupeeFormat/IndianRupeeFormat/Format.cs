using System;

namespace IndianRupeeFormat
{
    public class Format
    {
        public string ReturnIndianRupee (int money)
        {
            string number = Convert.ToString(money);
            if (number.Length <= 3)
                return number;
            else
                return number.Substring(0,number.Length-3) + "Thousand " + number.Substring(number.Length - 3);
        }
    }
}
