
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeIsTuringEquation
{
    public class TuringTest
    {
        public bool IsTurning(string equation)
        {
            var result = false;

            var reversedEq = ReverseString(equation);
            var reversedEqArray = reversedEq.ToArray();
            var indexOfEquals = Array.FindIndex(reversedEqArray, m => m.ToString() == "=");
            var indexOfPlus = Array.FindIndex(reversedEqArray, m => m.ToString() == "+");

            var total = reversedEqArray.TakeWhile(m => m < reversedEq[indexOfEquals]);
            //var total = reversedEq.Substring(0, indexOfEquals);
            var firstInteger = reversedEq.Substring(indexOfEquals + 1, (indexOfPlus - 1 - indexOfEquals));
            var secondInteger = reversedEq.Substring(indexOfPlus + 1);



            if (Convert.ToInt32(firstInteger) + Convert.ToInt32(secondInteger) == Convert.ToInt32(total))
            {
                result = true;
            }

            return result;
        }

        private string ReverseString(string input)
        {
            var inputCharArray = input.ToCharArray();
            Array.Reverse(inputCharArray);
            return new string(inputCharArray);
        }
    }
}
