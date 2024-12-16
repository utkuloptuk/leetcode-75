using System.Drawing;

namespace leetcode_75._27_remove_element;

public static class Solution
{
    public static int RemoveNumbers(int[] nums,int val)
    {
        List<int> revomedItemIndex= new List<int>();
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] == val)
                revomedItemIndex.Add(i);

        int numPointer = 0;

        for (int i = nums.Length - revomedItemIndex.Count; i < nums.Length; i++)
        {
            if (revomedItemIndex[numPointer] < i && nums[i] != val)
            {
                var temp = nums[i];
                nums[i] = nums[revomedItemIndex[numPointer]];
                nums[revomedItemIndex[numPointer]] = temp;
                numPointer++;
            }
        }
        return nums.Length-revomedItemIndex.Count;
    }
}