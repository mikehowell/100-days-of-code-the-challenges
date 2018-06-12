using System;
using System.Collections.Generic;
using System.Linq;

namespace ZerosAndOnes
{
    public class ParseString
    {
        public int ShortestString(string zerosAndOnes)
        {
            int count = 0;
            var arrayOfZerosAndOnes = zerosAndOnes.ToCharArray();

            char[] processedArray = ProcessArray(arrayOfZerosAndOnes);

            foreach (var character in processedArray)
            {
                if (!character.Equals(' '))
                {
                    count += 1;
                }
            }

            return count;
        }

        private Char[] ProcessArray(char[] arrayOfZerosAndOnes)
        {
            List<char> charArray = new List<char>();

            for (int i = 0; i < arrayOfZerosAndOnes.Length; i++)
            {
                if (i == 0)
                {
                    charArray.Add(arrayOfZerosAndOnes[i]);
                }
                else
                {
                    if (arrayOfZerosAndOnes[i-1] != arrayOfZerosAndOnes[i])
                    {
                        charArray.Add(' ');
                    }
                    else
                    {
                        charArray.Add(arrayOfZerosAndOnes[i]);
                    }
                }
            }

            return charArray.ToArray<char>();
        }
    }
}
