using System;

namespace ReverseArray
{
    public class Reverse
    {
        public string ArrayInput(params string[] input)
        {
            var output = String.Empty;

            try
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    output += input[i].ToString() + " ";
                }

                output = output.Remove(output.Length - 1);
            }
            catch (System.Exception)
            {
                Console.WriteLine("An error has occurred.");
            }

            return output;
        }

    }
}
