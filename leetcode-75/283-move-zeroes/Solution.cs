namespace leetcode_75._283_move_zeroes;

public static class Solution
{
    public static void MoveZeroes(int[] nums)
    {
        int endOftheList = nums.Length - 1;
        int slowPointer = 0;
        int fastPointer = 0;
        while (endOftheList >= fastPointer)
        {
            if (nums[fastPointer] != 0 )
            {
                (nums[slowPointer], nums[fastPointer]) = (nums[fastPointer], nums[slowPointer]);
                slowPointer++;
            }

            fastPointer++;
        }
    }
}