using System;

namespace HumanReadableTime
{
    public class ReadableTime
    {
        private int _seconds;
        private int _minutes;
        private int _hours;

        public string ConvertToReadableTime(int timeInSeconds)
        {
            string result = String.Empty;

            try
            {
                if (timeInSeconds > 359999)
                {
                    throw new ArgumentOutOfRangeException("Input value should not exceed 359999");
                }
                
                _seconds = timeInSeconds % 60;
                _minutes = (timeInSeconds / 60) % 60;
                _hours = (timeInSeconds / 60) / 60;

                result = PadTime(_hours) + ":" + PadTime(_minutes) + ":" + PadTime(_seconds);
            }
            catch (Exception ex)
            {
                throw;
            }
           

            return result; 
        }

        private string PadTime(int time)
        {
            var stringTime = time.ToString();
            if (stringTime.Length == 1)
            {
                return "0" + time.ToString();
            }
            else
            {
                return time.ToString();
            }
        }
    }
}
