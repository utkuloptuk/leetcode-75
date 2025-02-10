namespace leetcode_75._35_search_insert_position;

public static class Solution
{
    public static int SearchInsert(int[] nums, int target) {
        int low = 0, high = nums.Length - 1;
        if (nums[low] > target)
            return 0;
        if (nums[high] < target)
            return high + 1;
        while (low <= high)
        {
            int mid = (high + low) / 2;
            if (nums[mid]==target)
                return mid;
            if (nums[mid] < target && nums[mid + 1] > target) 
                return mid+1;
            if(nums[mid]>target)
                high = high - 1;
            if(nums[mid] < target)
                low = low + 1;
        }

        return 0;
    }
}