using System.Collections.Generic;
using System.Linq;

namespace EvenFibonacciNumbers
{
    public class FibonacciNumbers
    {

        private int _firstNumber;
        private int _secondNumber;
        private readonly int _maxValue;

        public FibonacciNumbers(int firstNumber, int secondNumber, int maxValue)
        {
            this._firstNumber = firstNumber;
            this._secondNumber = secondNumber;
            this._maxValue = maxValue;
        }

        IEnumerable<int> fibonacciSequence()
        {
            yield return 1;
            while (true)
            {
                int n = _firstNumber + _secondNumber;
                _firstNumber = _secondNumber;
                _secondNumber = n;
                yield return n;
            }
        }

        public long SumOfEvenNumbersInSequence()
        {
            long sum = 0;

            foreach (int i in fibonacciSequence().TakeWhile(i => i < _maxValue).Where(i => i % 2 == 0))
            {
                sum += i;
            }
            return sum;
        }
    }
}
