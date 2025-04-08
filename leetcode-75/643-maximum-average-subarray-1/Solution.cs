namespace leetcode_75._643_maximum_average_subarray_1;

public static class Solution
{
    public static double FindMaxAverage(int[] nums, int k)
    {
        //On time O1 memory
        if(nums.Length==1)
            return nums[0];
        int first = 0;
        int second = 0;
        int total = 0;
        double average = double.MinValue;
        while (second < nums.Length)
        {
            if (second - first < k-1)
            {
                    total += nums[second];
                    // double mockAverage = (double)total /( second - first + 1);
                    // average=Math.Max(average, mockAverage);
                    second++;
            }
            else
            {

                total +=  nums[second];
                double mockAverage = (double)total /k;
                average=Math.Max(average, mockAverage);
                total -= nums[first];
                second++;
                first++;
            }
        }
        return average;
    }
}