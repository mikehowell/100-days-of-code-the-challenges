namespace SumOfMultiples
{
    public class SumOfMultiples
    {
        public int Sum { get; set; }

        public SumOfMultiples()
        {
            for (int i = 1; i < 1000; i++)
            {
                if(MultipleOfThree(i) || MultipleOfFive(i))
                {
                    Sum += i;
                }
            }
        }

        private bool MultipleOfThree(int number)
        {
            if (number % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool MultipleOfFive(int number)
        {
            if (number % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
