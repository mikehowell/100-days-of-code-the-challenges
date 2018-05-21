using System;
using System.Collections.Generic;

namespace DisariumNumbers
{
    public class DisariumTest
    {
        public bool IsDisarium (int number)
        {
            var inputNumber = number;
            var numbers = new Stack<int>();

            for (; inputNumber > 0; inputNumber /= 10)
                numbers.Push(inputNumber % 10);

            double sumOfDigits = 0;

            int[] numberArray = numbers.ToArray();

            for (int i = 0; i < numberArray.Length; i++)
                sumOfDigits += Math.Pow(Convert.ToDouble(numberArray[i]), Convert.ToDouble((i + 1)));

            if (sumOfDigits == Convert.ToDouble(number))
                return true;

            return false;
        }
    }
}
