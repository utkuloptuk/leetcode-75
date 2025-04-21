namespace leetcode_75._1984_minimum_difference_between_highestand_lowest;

public class Solution
{
    public static int MinimumDifference(int[] nums, int k)
    {
        //Onlogn time comp o1 memory
        if (nums.Length < 2)
            return 0;
        Array.Sort(nums);
        int diff = int.MaxValue;
        for (int i = 0; i < nums.Length - k+1; i++)
        {
            int mockDiff=-nums[i] + nums[i+k-1];
            diff = Math.Min(diff, mockDiff);
        }
        return diff;
    }
}