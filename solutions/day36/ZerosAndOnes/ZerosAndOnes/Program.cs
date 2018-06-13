using System;

namespace ZerosAndOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new ParseString();
            int result = parser.ShortestString("110100");
            Console.WriteLine(result);
            result = parser.ShortestString("01010");
            Console.WriteLine(result);
        }
    }
}
