using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPhoneCall
{

    class Program
    {
        static void Main(string[] args)
        {
            var duration = new PhoneCall(3, 1, 2, 20);
            Console.WriteLine(duration.CallDuration());
        }
    }
}
