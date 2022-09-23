
namespace leetcode_75._152_maximum_product_subarray
{
    public static class Solution
    {
        public static int MaximumSubArrayMultiply(int[] inputArr)
        {
            int maxValue = inputArr.Max();
            int min = 1;
            int max = 1;
            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i].Equals(0))
                {
                    max = 1;
                    min = 1;
                }
                var temp = max * inputArr[i];
                max = Math.Max(max * inputArr[i], Math.Max(inputArr[i], min * inputArr[i]));
                min = Math.Min(min * inputArr[i], Math.Min(inputArr[i], temp));
                maxValue = Math.Max(max,maxValue);
            }
            return maxValue;
            //int max = 1;
            //int min = 1;
            //int maxValue = int.MinValue;
            //int multiply = 1;
            //for (int i = 0; i < inputArr.Length; i++)
            //{
            //    if (i.Equals(0))
            //        multiply *= inputArr[i];
            //    else
            //    {
            //        if (multiply < 0)
            //            multiply = min * inputArr[i];
            //        else
            //            multiply = max * inputArr[i];
            //    }
            //    if (multiply > maxValue)
            //        maxValue = multiply;
            //    if (!multiply.Equals(0))
            //    {
            //        max = Math.Abs(multiply);
            //        min = -Math.Abs(multiply);
            //    }
            //    else
            //    {
            //        max = 1;
            //        min = 1;
            //    }
            //}
            //int bigNum = inputArr.Max();
            //if (maxValue < bigNum)
            //    maxValue = bigNum;
            //return maxValue;
        }
        }
    }
