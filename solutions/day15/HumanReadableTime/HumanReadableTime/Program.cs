using System;

namespace HumanReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var hrt = new ReadableTime();

            Console.WriteLine(hrt.ConvertToReadableTime(359999));
            Console.WriteLine(hrt.ConvertToReadableTime(4056));
            Console.WriteLine(hrt.ConvertToReadableTime(360000));

            Console.ReadLine();
        }
    }
}
