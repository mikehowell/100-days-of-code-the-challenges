using System;
using System.Collections.Generic;

namespace SortIntegers
{
    public class Sort
    {
        public List<int> SortNumbers (List<int> numbers)
        {
            List<int> SortedList = new List<int>();

            foreach (var number in numbers)
                SortedList.Add(number);

            SortedList.Sort();

            return SortedList;
        }
    }
}
