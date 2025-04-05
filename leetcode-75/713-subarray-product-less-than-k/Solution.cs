namespace leetcode_75._713_subarray_product_less_than_k;

public static class Solution
{
    public static int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        
        //sliding window O(n) time 
        int count = 0;
        int multiply = 1;
        int left = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            multiply *= nums[right];
            while (multiply >= k && left <= right)
            {
                multiply /= nums[left];
                left++;
            }

            count += right - left +1;
        }
        return count;
        //brute force On2
        // int count = 0;
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     int first = i;
        //     int last = first;
        //     int multiply = 1;
        //     while (last < nums.Length)
        //     {
        //
        //         if (last != first)
        //             multiply *= nums[last];
        //         else
        //             multiply = nums[first];
        //         if (multiply < k)
        //         {
        //             count++;
        //         }
        //         else
        //             break;
        //
        //         last++;
        //     }
        // }
        //
        // return count;
    }
}