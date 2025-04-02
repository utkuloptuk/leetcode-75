namespace leetcode_75._611_valid_triange_number;

public static class Solution
{
    public static int TriangleNumber(int[] nums)
    {
        //twopointer n2
        Array.Sort(nums);
        int length=nums.Length;
        int counter = 0;
        for (int k = length - 1; k >= 2; k--)
        {
            int i = 0;
            int j = k - 1;

            while (i < j)
            {
                if (nums[i] + nums[j] > nums[k])
                {
                    counter += j - i;
                    j--;
                }
                else
                {
                    i++;
                }
            }
        }

        return counter;
        //bruteforce n3 
        // int first = 0;
        // int second = 1;
        // int count = 0;
        // int length = nums.Length;
        // while (first <= length - 3 && second <= length - 2)
        // {
        //     int third = second + 1;
        //     for (int i = second + 1; i < length; i++)
        //     {
        //         if (nums[first] + nums[second] > nums[i] && Math.Abs(nums[first] - nums[second]) < nums[i])
        //             count++;
        //         third++;
        //     }
        //
        //     if (third == length && second + 1 < length - 1)
        //     {
        //         second++;
        //         third = second + 1;
        //     }
        //
        //     if (second == length - 2 && third == length)
        // {
        //         first++;
        //         second=first+1;
        //     }
        // }
        // return count;
    }
}