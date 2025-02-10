namespace leetcode_75._704_binary_search;

public static class Solution
{
    public static int Search(int[] nums, int target) {
        int low = 0, high = nums.Length - 1;
        while (low <= high)
        {
            var mid = (low + high) / 2;
            if(nums[mid] == target)
                return mid;
            if (nums[mid] > target)
                high = high - 1;
            if(nums[mid] < target)
                low = low + 1;
        }
        return -1;
    }
}