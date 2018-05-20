using System;
using System.Text.RegularExpressions;

namespace ValidPhoneNumbers
{
    public class PhoneNumber
    {
        public bool IsValid (string phoneNumber)
        {
            Regex regex = new Regex(@"\(.*[\d{3}]\).* ?.*[\d{3}]-.*[\d{4}]");
            Match match = regex.Match(phoneNumber);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pn = new PhoneNumber();
            Console.WriteLine(pn.IsValid("(123) 456-7890"));
            Console.WriteLine(pn.IsValid("(1111)555 2345"));
            Console.WriteLine(pn.IsValid("(098) 123 4567"));
        }
    }
}
