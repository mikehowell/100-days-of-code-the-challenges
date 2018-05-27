using System;

namespace CompleteThePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var pc = new PatternCompletion();
                Console.WriteLine(pc.Pattern(11));
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred:\r\n\r\n{0}", e.Message);
            }

            Console.ReadLine();
        }
    }
}
