using System.Linq;

namespace ConvertToCamelCase
{
    public class Convert
    {
        public string ToCamelCase (string variableName)
        {
            string result = string.Empty;
            char delimiter = ' ';

            if (variableName.Contains("-"))
            {
                delimiter = '-';
            }
            else if (variableName.Contains("_"))
            {
                delimiter = '_';
            }

            string[] words = variableName.Split(delimiter);
            if (words.Length>0)
            {
                result += words[0];

                for (int i = 1; i < words.Length; i++)
                {
                    result += words[i].Substring(0,1).ToString().ToUpper() + words[i].Substring(1);
                }
            }
            else
            {
                return variableName;
            }

            return result;
        }
    }
}
