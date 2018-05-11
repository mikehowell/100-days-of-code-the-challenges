using System;

namespace IPV4Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            var ipv4Validator = new Validator();

            //valid
            Console.WriteLine(ipv4Validator.isValid("1.2.3.4"));
            Console.WriteLine(ipv4Validator.isValid("123.45.67.89"));
            Console.WriteLine(ipv4Validator.isValid("12.255.56.1"));

            //invalid
            Console.WriteLine(ipv4Validator.isValid("1.2.3"));
            Console.WriteLine(ipv4Validator.isValid("1.2.3.4.5"));
            Console.WriteLine(ipv4Validator.isValid("123.456.78.90"));
            Console.WriteLine(ipv4Validator.isValid("123.045.067.089"));
        }
    }
}
