using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_75._238_product_of_array_except_self
{
    public static class Solution
    {
        public static int[] ArrayElementsMultiplyExceptSelf(int[] input)
        {
            int[] finalArray = new int[input.Length];
            int prefix = 1;
            for (int i = 0; i < input.Length; i++)
            {
                finalArray[i] = prefix;
                prefix = (int)input[i] * prefix;
            }
            int postfix = 1;
            for (int i = (input.Length - 1); i >= 0; i--)
            {
                finalArray[i] = finalArray[i] * postfix;
                postfix = postfix * input[i];
            }
            return finalArray;
        }
    }
}
