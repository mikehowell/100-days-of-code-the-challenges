namespace StrongN
{
    public class StrongNumber
    {
        private int _factorialResult = 0;
        private int _number = 0;

        public StrongNumber()
        {
        }

        public StrongNumber(int number)
        {
            this._number = number;
            SumFactorial();
        }

        public bool IsStrongN()
        {
            if (this._factorialResult == this._number)
            {
                return true;
            }

            return false;
        }

        private void SumFactorial()
        {
            string numberString = this._number.ToString();
            var numberCharArray = numberString.ToCharArray();

            foreach (var number in numberCharArray)
            {
                this._factorialResult += Factorial(int.Parse(number.ToString()));
            }
        }

        private int Factorial (int number)
        {
            if (number >= 2)
            {
                return number * Factorial(number - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
