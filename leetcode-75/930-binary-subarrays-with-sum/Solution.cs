namespace leetcode_75._930_binary_subarrays_with_sum;

public static class Solution
{
    public static int NumSubarraysWithSum(int[] nums, int goal)
    {
        return AtMost(nums, goal) - AtMost(nums, goal - 1);

        //wrong approach
        // if (nums.Length<2 )
        //     return nums.Length==1&&goal==nums[0]?1:0;
        // int first = 0,sum = 0,counter=0;
        // for (int second = 0; second < nums.Length; second++)
        // {
        //
        //     sum += nums[second];
        //     while (sum > goal && first <= second)
        //     {
        //         sum -= nums[first];
        //         first++;
        //     }
        //
        //     if (sum == goal)
        //     {
        //         counter++;
        //         int tempLeft = first;
        //         int tempSum = sum;
        //         while (tempLeft < second && tempSum == goal) {
        //             tempSum -= nums[tempLeft];
        //             tempLeft++;
        //             if (tempSum == goal)
        //                 counter++;
        //         }
        //     }
        // }
        // return counter;
    }
    //sliding window 
    private static int AtMost(int[] nums, int goal) {
        if (goal < 0) return 0;
        int left = 0, currentSum = 0, result = 0;
        for (int right = 0; right < nums.Length; right++) {
            currentSum += nums[right];
            while (currentSum > goal) {
                currentSum -= nums[left];
                left++;
            }
            result += right - left + 1;
        }
        return result;
    }
}