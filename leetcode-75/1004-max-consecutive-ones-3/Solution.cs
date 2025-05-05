namespace leetcode_75._1004_max_consecutive_ones_3;

public static class Solution
{
    public static int LongestOnes(int[] nums, int k)
    {
        //sliding window On time
        int left = 0;
        int maxCount = 0;
        int max = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
                maxCount++;
            while (maxCount > k)
            {
                if (nums[left]==0)
                    maxCount--;
                left++;
            }
            max=Math.Max(max,right-left+1);
        }

        return max;
        //bruteforce On2 time 
        // int max = 0;
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     int mockK = k;
        //     int mockCount = 0;
        //     for (int j = i; j < nums.Length; j++)
        //     {
        //         if(nums[j] == 0)
        //             mockK--;
        //         if (mockK < 0)
        //             break;
        //         mockCount++;
        //
        //     }
        //     max=Math.Max(max,mockCount);
        // }
        // return max;
    }
}