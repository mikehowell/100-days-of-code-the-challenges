using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    public class CaesarCipher
    {
        public string Encode(string s, int shift)
        {
            char[] sCharArray = s.ToCharArray();
            StringBuilder output = new StringBuilder();
            

            foreach (var character in sCharArray)
            {
                //ASCII Decimal values: A-Z = 65 to 90 inclusive and a-z = 97 to 122 inclusive
                if ((character < 65 || character > 90) && (character < 97 || character > 122))
                {
                    output.Append(character);
                }
                else
                {
                    int result = Convert.ToInt32(character) + shift;
                    if (character < 90 && result > 90)
                    {
                        result = result - 91 + 65;
                    }

                    if (character < 122 && result > 122)
                    {
                        result = result - 123 + 97;
                    }

                    output.Append(Convert.ToChar(result));
                }
                
            }

            return output.ToString();
        }

        public string Decode(string s, int shift)
        {
            throw new NotImplementedException();
        }
    }
}
