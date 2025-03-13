namespace leetcode_75._300_Longest_Increasing_subsequence;

public class Solution
{
    public static int LengthOfLIS(int[] nums)
    {
        //Dynamic programming solution
        List<int> count = new List<int>();
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
            count.Add(1);
        
        for (int i = nums.Length-2; i >= 0; i--)
        {
            for (int j = i+1; j<nums.Length; j++)
            {
                if(nums[i]<nums[j])
                    count[i]=Math.Max(count[i],1+count[j]);
            }
        }

        for (int i = 0; i < count.Count; i++)
        {
            if(count[i] > result) result=count[i];
        }
        return result;
        // int min = int.MaxValue;
        // int last = int.MaxValue;
        // int max = int.MinValue;
        // int count = 1;
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (last < nums[i] && min < nums[i])
        //         count++;
        //     if (max > nums[i])
        //         count--;
        //     if (min > nums[i])
        //     {
        //         min = nums[i];
        //         count = 1;
        //     }
        //     if(max < nums[i])
        //         max = nums[i];
        //
        //     last = nums[i];
        //
        // }
        // return count;
    }
}