namespace leetcode_75._16_3sum_closest;

public static class Solution
{
    public static int ThreeSumClosest(int[] nums, int target)
    {
        //more efficiency solution (O(n*2) time , O(1) memory

        Array.Sort(nums);
        int closest = nums[0]+nums[1]+nums[2];
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int low = i + 1;
            int high = nums.Length - 1;
            while (low < high)
            {
                if(Math.Abs(closest-target)> Math.Abs(-target+nums[i] + nums[low] + nums[high]))
                    closest = nums[i] + nums[low] + nums[high];
                if (target < nums[i] + nums[low] + nums[high])
                    high--;
                else
                    low++;
            }
        }

        return closest;
        
        //My solution (O(n*2) time, O(n) memory)
        // int closestDifference = int.MaxValue;
        // int closest = 0;
        // int first = 0;
        // if(nums.Length == 3)
        //     return nums[0]+nums[1]+nums[2];
        // while (first < nums.Length - 2)
        // {
        //     int second = first+1;
        //     int third = second+1;
        //     while (second < nums.Length-1)
        //     {
        //         if (Math.Abs(-target + (nums[first] + nums[second] + nums[third])) < closestDifference)
        //         {
        //             closestDifference = Math.Abs(-target + (nums[first] + nums[second] + nums[third]));
        //             closest=nums[first]+nums[second]+nums[third];
        //             if (closest == target)
        //                 return closest;;
        //
        //         }
        //         if (third == nums.Length-1)
        //         {
        //             second++;
        //             third=second+1;
        //         }
        //         else
        //             third++;
        //     }
        //     first++;
        // }
        //
        // return closest;
    }
}