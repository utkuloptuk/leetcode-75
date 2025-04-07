namespace leetcode_75._413_aritmatic_slides;

public static class Solution
{
    public static int NumberOfArithmeticSlices(int[] nums)
    {
        //On timecomplexity
        if (nums.Length < 3)
            return 0;
        int diff=nums[1]-nums[0];
        int count = 0;
        int result = 0;
        for (int i = 2; i < nums.Length; i++)
        {
            int newDiff=nums[i]-nums[i-1];
            if (newDiff == diff)
            {
                count++;
                result += count;
            }
            else
            {
                count = 0;
                diff = newDiff;
            }
        }
        return result;
    }
    //time limit exceed On3 (bruteforce)
    // public static int NumberOfArithmeticSlices(int[] nums)
    // {
    //     int result = 0;
    //     for (int i = 2; i < nums.Length; i++)
    //     {
    //         result+=checkAritmaticStatus(nums,i);
    //     }
    //     return result;
    // }
    //
    // private static int checkAritmaticStatus(int[] nums,int counter)
    // {
    //     int first = 0;
    //     int last = counter;
    //     int sum = 0;
    //     bool checker = true;
    //     int difference=Math.Abs(nums[first] - nums[1]);
    //     while (last < nums.Length)
    //     {
    //         for(int i=first; i<last; i++)
    //         {
    //             if (Math.Abs(nums[i + 1] - nums[i]) != difference)
    //             {        checker = false;}
    //         }
    //
    //         if (checker)
    //             sum++;
    //         checker = true;
    //         first++;
    //         last++;
    //     }
    //
    //     return sum;
    // }
}