using System;
using System.Text;

namespace SuperReducedString
{
    public class Reduce
    {
        public string ReduceString(string input)
        {
            string output = String.Empty;
            StringBuilder sb = new StringBuilder(input);
            int index = 0;

            while (index < sb.Length - 1)
            {
                if (sb[index] == sb[index + 1])
                {
                    sb.Remove(index, 1);
                    if (index > 0)
                    {
                        index--;
                    }
                }
                else
                {
                    index++;
                }
            }

            if (sb.Length > 0)
            {
                output = sb.ToString();
            }
            else
            {
                output = "Empty String";
            }

            return output;
        }
    }
}
