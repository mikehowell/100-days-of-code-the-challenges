using System;
using System.Collections.Generic;

namespace MiniMax
{
    public class MiniMaxSum
    {
        private readonly List<Int64> inputList;

        public MiniMaxSum(params Int64[] inputs)
        {
            inputList = new List<Int64>();
            foreach (var input in inputs)
            {
                inputList.Add(input);
            }

            inputList.Sort();
        }

        public Int64 MinSum()
        {
            Int64 result = 0;

            for (int i = 0; i < inputList.Count - 1 ; i++)
            {
                result += inputList[i];
            }

            return result;
        }
        
        public Int64 MaxSum()
        {
            Int64 result = 0;

            for (int i = 1; i < inputList.Count; i++)
            {
                result += inputList[i];
            }

            return result;
        }
    }
}
