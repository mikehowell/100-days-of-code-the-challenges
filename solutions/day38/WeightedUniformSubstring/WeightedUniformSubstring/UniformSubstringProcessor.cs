using System.Collections.Generic;
using System.Linq;

namespace WeightedUniformSubstring
{
    public class UniformSubstringProcessor
    {
        public string[] weightedUniformStrings(string s, int[] queries)
        {
            string[] result = new string[queries.Length];

            List<string> contiguousStrings = uniformContiguousStrings(s);
            List<int> stringValues = new List<int>();

            foreach (var contiguousString in contiguousStrings)
                stringValues.Add(uniformContiguousStringValue(contiguousString));

            for (int i = 0; i < queries.Length; i++)
            {
                if (stringValues.Contains(queries[i]))
                    result[i] = "YES";
                else
                    result[i] = "NO";
            }

            return result;
        }

        private List<string> uniformContiguousStrings(string s)
        {
            List<string> uniformStrings = new List<string>();
            List<char> sCharList = new List<char>(s.ToCharArray());

            //add unique single characters from string
            foreach (var character in sCharList)
            {
                if (!uniformStrings.Contains(character.ToString()))
                {
                    uniformStrings.Add(character.ToString());
                }
            }

            //add other contiguous uniform strings i.e. aa, aaa, aaaa etc
            //this bit has been really hard to figure out,
            //the code below works but as always, there is probably a better way to do this!
            Stack<string> stackOfStringsToAdd = new Stack<string>();
            var current = s[0];
            stackOfStringsToAdd.Push(current.ToString());
            var stringToAdd = string.Empty;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i].ToString() == stackOfStringsToAdd.Peek())
                {
                    stackOfStringsToAdd.Push(s[i].ToString());

                    foreach (var item in stackOfStringsToAdd)
                        stringToAdd += item;

                    if (!uniformStrings.Contains(stringToAdd))
                        uniformStrings.Add(stringToAdd);

                    stringToAdd = string.Empty;
                }
                else
                {
                    stackOfStringsToAdd.Clear();
                    stringToAdd = string.Empty;
                }

                current = s[i];
                if (stackOfStringsToAdd.Count == 0)
                    stackOfStringsToAdd.Push(current.ToString());
            }

            return uniformStrings;
        }

        private int uniformContiguousStringValue(string s)
        {
            int result = 0;

            char[] sCharArray = s.ToCharArray();

            foreach (var character in sCharArray)
            {
                result += character - 96;
            }

            return result;
        }
    }
}
