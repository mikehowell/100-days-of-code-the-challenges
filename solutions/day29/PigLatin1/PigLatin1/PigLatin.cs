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
                result = word.Substring(indexOfFirstVowel) + word.Substring(0, indexOfFirstVowel) + "ay";
            }

            return result.Trim();
        }
    }
}
