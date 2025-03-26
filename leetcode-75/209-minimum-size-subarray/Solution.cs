namespace leetcode_75._209_minimum_size_subarray;

public static class Solution
{
    public static int MinSubArrayLen(int target, int[] nums)
    {
        //On time o1 memory
        int result = int.MaxValue;
        int left = 0;
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            while (sum >= target)
            {
                result = Math.Min(result, i-left+1);
                sum -= nums[left];
                left++;
            }
        }
        return result == int.MaxValue?0: result;
        //time complexity On2 ı get time exceed for case 19
        // int result=int.MaxValue;
        // int first = 0;
        // int last = 0;
        // if (nums.Length == 1 && nums[0] < target)
        //     return 0;
        // while (first <= nums.Length - 1&&last <= nums.Length-1)
        // {
        //     int temp = 0;
        //     int mock = 0;
        //     for (int i = first; i <= last; i++)
        //     {
        //         temp=temp + nums[i];
        //         mock++;
        //     }
        //     if (last == nums.Length - 1 && first == 0 && temp < target)
        //         return 0;
        //     if (temp >= target)
        //     {
        //         result = Math.Min(result, mock);
        //         first++;
        //     }
        //     else
        //         last++;
        // }
        // return result;
    }
}