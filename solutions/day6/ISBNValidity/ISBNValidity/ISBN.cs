using System;
using System.Linq;

namespace ISBNValidity
{
    public class ISBN
    {
        public bool IsValid(string ISBN)
        {
            bool result = false;
            try
            {
                if (ISBN.Length != 10)
                    throw new Exception(String.Format("Entered ISBN number is not the correct length.\r\nPlease enter a value that is 10 digits long.\r\nValue entered is {0} digits long.", ISBN.Length.ToString()));

                char[] ISBNArray = ISBN.ToArray();
                int sum = 0;
                for (int i = 10; i > 0; i--)
                {
                    sum = sum + (ISBNArray[i-1] * i);
                }

                if (sum % 11 == 0)
                    result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("The following error has occurred: {0}", ex.Message);
                throw;
            }

            return result;
        }
    }
}
