using System;
using System.Collections.Generic;

namespace Day1
{
    public class ProduceSample
    {
        public List<int> ReturnSample (int N, int M)
        {
            var result = new List<int>();

            for (int i = 0; i < N; i++)
            {
                result.Add (M - 1 - i);
            }

            return result;
        }
    }
}
