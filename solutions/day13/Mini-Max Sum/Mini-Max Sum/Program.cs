using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace MiniMax
{
    class Program
    {
        static void Main(string[] args)
        {
            var miniMaxSum = new MiniMaxSum(1, 2, 3, 4, 5);
            Console.WriteLine(miniMaxSum.MaxSum());
            Console.WriteLine(miniMaxSum.MinSum());
        }
    }
}
