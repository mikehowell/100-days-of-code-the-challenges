using System;

namespace HumanReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                var hrt = new ReadableTime();

                Console.WriteLine(hrt.ConvertToReadableTime(359999));
                Console.WriteLine(hrt.ConvertToReadableTime(4056));

                Console.WriteLine(hrt.ConvertToReadableTime(360000));
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred: {0}", ex.Message);
            }

            Console.ReadLine();
        }
    }
}
