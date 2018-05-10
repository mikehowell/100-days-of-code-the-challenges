using System.Collections.Generic;

namespace DivisibilityByThirteen
{
    public class Thirteen
    {
        private List<int> _integerRemainders = new List<int> (new int[] { 1, 10, 9, 12, 3, 4 });

        public int Thirt (int number)
        {
            int[] remainders = { 1, 10, 9, 12, 3, 4 };
            int sum = 0;

            for (int r = 0; number > 0; r++)
            {
                if (r == remainders.Length)
                {
                    r = 0;
                }

                sum += (int)(number % 10 * remainders[r]);
                number /= 10;
            }

            if (sum > 99) return Thirt(sum);

            return sum;
        }
    }
}
