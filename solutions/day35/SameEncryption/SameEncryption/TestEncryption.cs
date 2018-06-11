using System.Collections.Generic;

namespace SameEncryption
{
    public class TestEncryption
    {
        public bool AreSame(string s1, string s2)
        {
            if (s1[0] != s2[0] && s1[s1.Length] != s2[s2.Length])
            {
                return false;
            }

            if (Encrypt(s1) != Encrypt(s2))
            {
                return false;
            }

            return true;
        }

        private string Encrypt (string message)
        {
            string firstCharacter = message.Substring(0, 1);
            string lastCharacter = message.Substring(message.Length - 1);
            int middleCharactersLength = (message.Substring(1, message.Length - 2)).Length;

            return firstCharacter + ReduceNumberToSingleDigit(middleCharactersLength) + lastCharacter;
        }

        private string ReduceNumberToSingleDigit(int number)
        {
            var result = string.Empty;

            if (number>10)
            {
                List<int> numberArray = new List<int>();
                while (number > 0)
                {
                    numberArray.Add(number % 10);
                    number = number / 10;
                }

                numberArray.Reverse();

                int total = 0;
                foreach (var num in numberArray)
                {
                    total += num;
                }

                if (total > 10)
                {
                    ReduceNumberToSingleDigit(total);
                }
                else
                {
                    result =  total.ToString();
                }
            }
            else
            {
                result = number.ToString();
            }

            return result;
        }
    }
}
