namespace LongestPhoneCall
{
    public class PhoneCall
    {
        private readonly int _costOfFirstMinute;
        private readonly int _costOfMinutesTwoToTen;
        private readonly int _costOfMinuteElevenAndAbove;
        public int _totalChange { get; set; }

        public PhoneCall(int CostOfFirstMinute, int CostOfMinutesTwoToTen, int CostOfMinuteElevenAndAbove, int TotalChange)
        {
            _costOfFirstMinute = CostOfFirstMinute;
            _costOfMinutesTwoToTen = CostOfMinutesTwoToTen;
            _costOfMinuteElevenAndAbove = CostOfMinuteElevenAndAbove;
            _totalChange = TotalChange;
        }

        public int CallDuration()
        {
            int totalMinutes = 0;
            int counter = 1;

            while (_totalChange > 0)
            {
                if (counter == 1)
                {
                    _totalChange = _totalChange - _costOfFirstMinute;
                    totalMinutes += 1;
                }
                else if (counter >=2 && counter <= 10)
                {
                    _totalChange = _totalChange - _costOfMinutesTwoToTen;
                    totalMinutes += 1;
                }
                else if (counter > 10)
                {
                    _totalChange = _totalChange - _costOfMinuteElevenAndAbove;
                    totalMinutes += 1;
                }

                counter++;
            }

            return totalMinutes;
        }
    }
}
