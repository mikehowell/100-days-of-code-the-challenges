using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "EbnhGfjklmjhgz";
            var s2 = "Eabcz";

            TestEncryption te = new TestEncryption();
            Console.WriteLine(te.AreSame(s1, s2));
        }
    }
}
