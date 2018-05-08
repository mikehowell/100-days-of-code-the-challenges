namespace SumOfPositiveNumbers
{
    public class Sum
    {
        private int Total;
        public int PositiveSum(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    Total += number;
                }
            }

            return Total;
        }
    }
}
