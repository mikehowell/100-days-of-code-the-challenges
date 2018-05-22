using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyStopWatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            try
            {
                Console.WriteLine("Start the stop watch Y/N");
                var response = Console.ReadLine();

                while (response.ToUpper() == "Y")
                {
                    Console.WriteLine("Enter a duration to run the stop watch in seconds");
                    int duration = Convert.ToInt32(Console.ReadLine());

                    sw.Start();
                    Thread.Sleep(duration * 1000);
                    sw.Stop();
                    Console.WriteLine("Run the stopwatch again Y/N");
                    response = Console.ReadLine().ToUpper();
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred: {0}", e.Message);
            }
        }
    }
}
