
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTuringEquation
{
    public class TuringTest
    {
        public bool IsTurning(string equation)
        {
            var result = false;

            int plusSign = equation.IndexOf('+');
            int equalsSign = equation.IndexOf('=');

            char[] equationCharacters = equation.ToCharArray();

            var firstInteger = string.Empty;
            var secondInteger = string.Empty; 
            var total = string.Empty;

            for (int i = 0; i < equationCharacters.Length; i++)
            {
                if (i < plusSign) { firstInteger += equationCharacters[i]; }

                if (i > plusSign && i < equalsSign) { secondInteger += equationCharacters[i].ToString(); }

                if (i > equalsSign) { total += equationCharacters[i]; }
            }

            if (Convert.ToInt32(ReverseString(firstInteger)) + Convert.ToInt32(ReverseString(secondInteger)) == Convert.ToInt32(ReverseString(total)))
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
