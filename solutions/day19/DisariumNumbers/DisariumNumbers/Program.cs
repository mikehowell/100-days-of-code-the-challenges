using System;

namespace DisariumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = new DisariumTest();
            Console.WriteLine(dt.IsDisarium(89)); //true
            Console.WriteLine(dt.IsDisarium(135)); //true
            Console.WriteLine(dt.IsDisarium(175)); //true
            Console.WriteLine(dt.IsDisarium(518)); //true
            Console.WriteLine(dt.IsDisarium(598)); //true
            Console.WriteLine(dt.IsDisarium(564));//false
            Console.WriteLine(dt.IsDisarium(400));//false
            Console.WriteLine(dt.IsDisarium(102));//false
        }
    }
}
