using System;
using System.Text;

namespace CompleteThePattern
{
    public class PatternCompletion
    {
        public string Pattern(int number)
        {
            if (number < 1) { return string.Empty; }

            string result = string.Empty;
            StringBuilder patternBuilder = new StringBuilder();

            try
            {
                for (int i = 1; i <= number; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        patternBuilder.Append(i);
                    }

                    patternBuilder.AppendLine();
                }
            }
            catch (Exception)
            {
                throw;
            }

            result = patternBuilder.ToString();
            return result;
        }
    }
}
