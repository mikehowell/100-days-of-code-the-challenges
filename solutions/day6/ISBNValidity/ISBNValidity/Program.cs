using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ISBNValidity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ISBN number to check");
            var enteredISBN = Console.ReadLine();

            var isbn = new ISBN();
            var isValid = String.Empty;
            if (isbn.IsValid(enteredISBN))
                isValid = "valid";
            else
                isValid = "not valid";

            Console.WriteLine("The ISBN number: {0} is {1}.",enteredISBN,isValid);
        }
    }
}
