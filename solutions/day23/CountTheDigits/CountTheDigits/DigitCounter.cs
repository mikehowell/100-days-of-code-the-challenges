using System;
using System.Collections.Generic;

namespace CountTheDigits
{
    public class DigitCounter
    {
        private int _n;
        private int _d;
        private int _digitCount;
        public DigitCounter(int n, int d)
        {
            if (n >= 0 && (d >= 0 && d <= 9))
            {
                this._n = n;
                this._d = d;
            }
            else
            {
                throw new ArgumentOutOfRangeException("n should be greater than 0 and d should be between 0 and 9 inclusive");
            }
        }
        public int nb_dig()
        {
            List<int> listOfSquares = new List<int>();

            for (int i = 0; i <= _n; i++)
            {
                listOfSquares.Add(nSquared(i));
            }

            foreach (var number in listOfSquares)
            {
                Contains_d(number);
            }

            return _digitCount;
        }

        private int nSquared(int input)
        {
            return input * input;
        }

        private void Contains_d(int number)
        {
            var inputNumber = number;
            var numbers = new Stack<int>();

            for (; inputNumber > 0; inputNumber /= 10)
                numbers.Push(inputNumber % 10);

            int[] numberArray = numbers.ToArray();

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i]==_d) {_digitCount += 1;}
            }
        }
    }
}
