using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_75._53_maximum_subarray
{
    public static class Solution
    {
        public static int Maximum_SubArray_Sum(int[] inputList)
        {
            int maxValue = int.MinValue;
            int sum = 0;
            for(int i=0; i<inputList.Length;i++)
            {
                sum+=inputList[i];
                if(maxValue<sum)
                    maxValue = sum;
                if (sum < 0)
                    sum = 0;
            }
            return maxValue;
        }
    }
}
