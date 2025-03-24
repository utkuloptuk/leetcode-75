namespace leetcode_75._162_find_peak_element;

public static class Solution
{
    public static int FindPeakElement(int[] nums)
    {
        int first = 0;
        int last = nums.Length - 1;
        while (first <= last)
        {
            if (nums[first] < nums[last])
                first++;
            else
                last--;
        }
        return first;
    }
}