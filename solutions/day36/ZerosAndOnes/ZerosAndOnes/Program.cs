using System.Text;
using System.Threading.Tasks;

namespace ZerosAndOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new ParseString();
            int result = parser.ShortestString("01010");
        }
    }
}
