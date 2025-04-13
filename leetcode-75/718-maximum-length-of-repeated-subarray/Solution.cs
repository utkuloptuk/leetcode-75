namespace leetcode_75._718_maximum_length_of_repeated_subarray;

public static class Solution
{
    public static int FindLength(int[] nums1, int[] nums2)
    {
        //slidingwindow
        int counter = 0;
        for (int i = 0; i < nums1.Length; i++)
        {
            int mockCounter = 0;
            for (int f = i, s = 0; f < nums1.Length && s < nums2.Length; f++, s++)
            {
                if (nums1[f] == nums2[s])
                {
                    mockCounter++;
                    counter = Math.Max(counter, mockCounter);
                }
                else
                    mockCounter = 0;
            }
        }

        for (int j = 1; j < nums2.Length; j++)
        {
            int mockCounter = 0;
            for (int f = j, s = 0; s < nums1.Length && f < nums2.Length; f++, s++)
            {
                if (nums1[s] == nums2[f])
                {
                    mockCounter++;
                    counter = Math.Max(counter, mockCounter);
                }
                else
                    mockCounter = 0;

            }
        }

        return counter;
        //bruteforce
        // int result = 0;
        // for (int i = 0; i < nums1.Length; i++)
        // {
        //     for (int j = 0; j < nums2.Length; j++)
        //     {
        //         int picker = 0;
        //         while (i + picker < nums1.Length && j + picker < nums2.Length && nums1[i + picker] == nums2[j + picker])
        //         {
        //             picker++;
        //             result=Math.Max(result, picker);
        //         }
        //     }
        // }
        // return result;
        //Wrong approach
        // int counter = 0;
        // for (int i = nums1.Length-1; i >= 0; i--)
        // {
        //     int picker = 0;
        //     int j = 0;
        //     int index = nums1.Length-1-i;
        //     while(i>=j)
        //     {
        //
        //         if (nums1[index] != nums2[j])
        //         {
        //             picker = 0;
        //         }
        //
        //         if (nums1[index] == nums2[j])
        //         {
        //             picker++;
        //             index++;
        //             counter=Math.Max(counter, picker);
        //         }
        //
        //         j++;
        //     }
        // }
        // return counter;
    }
}