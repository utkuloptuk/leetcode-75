namespace leetcode_75._26_remove_duplicates_sorted_array;

public class Solution
{
    public static int RemoveDuplicatedSortedArray(int[] nums)
    {
        int slowPointer = 0;
        for (int fastPointer = 1; fastPointer < nums.Length; fastPointer++)
        {
            if (nums[fastPointer] != nums[slowPointer])
            {
                nums[++slowPointer] = nums[fastPointer];
            }
        }
        return slowPointer+1;
    }
}