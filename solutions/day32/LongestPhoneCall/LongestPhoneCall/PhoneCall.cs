namespace LongestPhoneCall
{
    public class PhoneCall
    {
        private readonly int _costOfFirstMinute;
        private readonly int _costOfMinutesTwoToTen;
        private readonly int _costOfMinuteElevenAndAbove;
        private readonly int _totalChange;

        public PhoneCall(int CostOfFirstMinute, int CostOfMinutesTwoToTen, int CostOfMinuteElevenAndAbove, int TotalChange)
        {
            _costOfFirstMinute = CostOfFirstMinute;
            _costOfMinutesTwoToTen = CostOfMinutesTwoToTen;
            _costOfMinuteElevenAndAbove = CostOfMinuteElevenAndAbove;
            _totalChange = TotalChange;
        }
        public int CallDuration()
        {
            int result = 0;



            return result;
        }
    }
}
