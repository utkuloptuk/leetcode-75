namespace leetcode_75._34_find_first_and_last_position_of_elemented_in_sorted_array;

public static class Solution
{
    
    public static int[] SearchRange(int[] nums, int target)
    {
        int left=Solution.binarySearch(nums, target,true);
        int right=Solution.binarySearch(nums, target, false);
        return new int[] { left, right };
        // List<int> result = new List<int>(){-1,-1};
        // int first = 0;
        // int last = nums.Length-1;
        // if(nums is null || nums.Length == 0)
        //     return result.ToArray();
        // if (nums.Length < 2)
        // {
        //     if(nums[0]==target)
        //         return new int[]{0,0};
        //     else
        //         return result.ToArray();
        // }
        // while (first <= last)
        // {
        //     int mid = first+(last - first) / 2;
        //     if (nums[mid] == target)
        //     {
        //         if (nums[mid - 1] == target)
        //         {
        //             result[0]=mid-1;
        //             result[1]=mid;
        //         }
        //
        //         else if (nums[mid + 1] == target)
        //         {
        //             result[0]=mid;
        //             result[1]=mid + 1;
        //         }
        //         else if (nums[mid - 1] != target&&nums[mid + 1] != target)
        //         {
        //             result[0]=mid;
        //             result[1]=mid;
        //         }
        //         break;
        //     }
        //     if(nums[mid]>target)
        //         last = mid - 1;
        //     if(nums[mid]<target)
        //         first = mid + 1;
        // }
        // return result.ToArray();
    }

    private static int binarySearch(int[] nums, int target, bool leftBias)
    {
        int start = 0;
        int end = nums.Length - 1;
        int index = -1;
        while (start <= end)
        {
            int mid = (end + start) / 2;
            if (nums[mid] < target)
                start = mid + 1;
            else if (nums[mid] > target)
                end = mid - 1;
            if (nums[mid] == target)
            {
                index = mid;
                if (leftBias)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
        }
        return index;
    }
}