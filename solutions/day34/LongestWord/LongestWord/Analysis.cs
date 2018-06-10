using System.Text;

namespace LongestWord
{
    public class Analysis
    {
        public string LongestsWord(string sen)
        {
            var result = string.Empty;

            var words = sen.Split(' ');

            int maxLength = 0;

            foreach (var word in words)
            {
                string wordWithoutPunctuation = RemovePunctuation(word);

                if (wordWithoutPunctuation.Length > maxLength)
                {
                    maxLength = wordWithoutPunctuation.Length;
                    result = wordWithoutPunctuation;
                }
            }

            return result;
        }

        private string RemovePunctuation(string word)
        {
            var result = new StringBuilder();
            var characters = word.ToCharArray();

            foreach (var character in characters)
            {
                if (!char.IsPunctuation(character))
                {
                    result.Append(character);
                }
            }

            return result.ToString();
        }
    }
}
