namespace LeapYearCheck
{
    public class LeapYearCheck
    {
        public string IsLeapYear (int year)
        {
            string result = "Not Leap";

            if (year % 4 == 0)
            {
                result = "Leap";

                if (year % 100 == 0)
                {
                    result = "Not Leap";

                    if (year % 400 == 0)
                    {
                        result = "Leap";
                    }
                }
            }

            ////Nice example below from StackOverflow
            //if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            //{
            //    result = "Leap";
            //}
            //else 
            //{
            //    result = "Not Leap";
            //}

            return result;
        }
    }
}
