using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var gr = new GenerateRandom(1, 40, 4);
                var myRandomNumbers = gr.RandomNumberList();

                foreach (var number in myRandomNumbers)
                {
                    Console.WriteLine(number.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred:\r\n\r\n{0}", e.Message);
            }

        }
    }
}
