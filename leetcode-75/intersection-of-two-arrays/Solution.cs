namespace leetcode_75.intersection_of_two_arrays;

public static class Solution
{
    public static int[] Intersection(int[] nums1, int[] nums2)
    {
        
        HashSet<int> set1 = new HashSet<int>(nums1);
        List<int> result =new List<int>();
        for (int i = 0; i < nums2.Length; i++)
        {
            if (set1.Contains(nums2[i]))
            {
                result.Add(nums2[i]);
                set1.Remove(nums2[i]);
            }
        }
        return result.ToArray();
        // int slowPointer = 0;
        // int fastPointer = 0;
        // List<int> result=new List<int>() ;
        // while (true)
        // {
        //     if (nums1.Length == slowPointer||((nums2.Length) == fastPointer))
        //         break;
        //     if (nums1[slowPointer] == nums2[fastPointer])
        //     {
        //         if(!result.Contains(nums1[slowPointer]))
        //             result.Add(nums1[slowPointer]);  
        //         slowPointer++;
        //         fastPointer = 0;
        //         continue;
        //
        //     }
        //
        //     if (fastPointer == (nums2.Length - 1)&&slowPointer <nums1.Length-1)
        //     {
        //         slowPointer++;
        //         fastPointer = 0;
        //     }
        //     if(nums2.Length != 1)
        //         fastPointer++;
        //     if ((nums1.Length - 1) == slowPointer && (nums2.Length - 1) == fastPointer)
        //     {
        //         if(nums1[slowPointer] == nums2[fastPointer])
        //             if(!result.Contains(nums1[slowPointer]))
        //                 result.Add(nums1[slowPointer]);  
        //         break;
        //     }
        //
        // }
        //     return result.ToArray();
    }
}