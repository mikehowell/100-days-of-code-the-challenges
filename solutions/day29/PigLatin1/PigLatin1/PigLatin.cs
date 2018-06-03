using System;

namespace PigLatin1
{
    public class PigLatin
    {
        public string EnglishToPigLatin(string s)
        {
            var result = string.Empty;

            if (s.Contains(" "))
            {
                var words = s.Split(' ');

                foreach (var word in words)
                {
                    result = result.Trim() + " " + EnglishToPigLatinHelper(word);
                }
            }
            else
            {
                result = EnglishToPigLatinHelper(s);
            }
            
            return result;
        }

        public string PigLatinToEnglish(string s)
        {
            throw new NotImplementedException();
        }

        private string EnglishToPigLatinHelper(string word)
        {
            var result = string.Empty;

            if (word.ToUpper().StartsWith("A") || word.ToUpper().StartsWith("E") || word.ToUpper().StartsWith("I") || word.ToUpper().StartsWith("O") || word.ToUpper().StartsWith("U"))
            {
                result = word + "way";
            }
            else
            {
                char[] chars = {'A', 'E', 'I', 'O', 'U' };
                int indexOfFirstVowel = word.ToUpper().IndexOfAny(chars);
                char[] upperAlphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

                if (word.IndexOfAny(upperAlphabet) == 0)
                {
                    var tempResult = word.Substring(indexOfFirstVowel) + word.Substring(0, indexOfFirstVowel) + "ay";
                    char[] resultArray = tempResult.ToCharArray();
                    result = resultArray[0].ToString().ToUpper() + tempResult.ToLower().Substring(1);
                }
                else
                {
                    result = word.Substring(indexOfFirstVowel) + word.Substring(0, indexOfFirstVowel) + "ay";
                }
            }

            if (word.EndsWith(",")) { result = result.Replace(",", "") + ","; }

            if (word.EndsWith(".")) { result = result.Replace(".", "") + "."; }

            return result.Trim();
        }
    }
}
