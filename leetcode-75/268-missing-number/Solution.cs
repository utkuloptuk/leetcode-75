namespace leetcode_75._268_missing_number;

public static class Solution
{
    public static int MissingNumber(int[] nums)
    {
        int expectedSum = 0;
        int currentSum = 0;
        for (int i = 0; i <= nums.Length; i++)
        {
            expectedSum += i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];
        }
        return expectedSum - currentSum;
        //not officent for timecomplexity
        // for (int i = 0; i <= nums.Length; i++)
        // {
        //     if(!nums.Contains(i))
        //         return i;
        // }
        //
        // return 0;
    }
}