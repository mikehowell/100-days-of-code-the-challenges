using System.Collections.Generic;
using System.Linq;

namespace ZerosAndOnes
{
    public class ParseString
    {
        public int ShortestString(string zerosAndOnes)
        {
            int count = 0;
            List<char> arrayOfZerosAndOnes = new List<char>(zerosAndOnes.ToArray<char>());
            List<char> processedArray = new List<char>();

            for (int i = 0; i < arrayOfZerosAndOnes.Count;)
            {
                if (!(i+2>arrayOfZerosAndOnes.Count))
                {
                    if (arrayOfZerosAndOnes[i] != arrayOfZerosAndOnes[i+1])
                    {
                        processedArray.Add(' ');
                        processedArray.Add(' ');
                        i += 2;
                    }
                    else
                    {
                        processedArray.Add(arrayOfZerosAndOnes[i]);
                        i++;
                    }
                }
                else if (arrayOfZerosAndOnes.Count > processedArray.Count)
                {
                    processedArray.Add(arrayOfZerosAndOnes[arrayOfZerosAndOnes.Count-1]);
                    i++;
                }
            }

            foreach (var character in processedArray)
            {
                if (!character.Equals(' '))
                {
                    count += 1;
                }
            }

            return count;
        }
    }
}
