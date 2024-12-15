namespace leetcode_75._88_Merge_Sorted_Array;

public  class Solution
{
    public  void Merge_Sorted_Array(int[] nums1, int m, int[] nums2, int n)
    {
        if(n==0)
            return;
        var last_index=nums1.Length-1;
        while (n > 0 && m > 0)
        {
            if (nums1[m - 1] <= nums2[n - 1])
            {
                nums1[last_index]=nums2[n - 1];
                n--;
            }
            else
            {
                nums1[last_index]=nums1[m - 1];
                m--;
            }
            last_index--;
        }

        while (n > 0)
        {
            nums1[last_index]=nums2[n - 1];
            n--;
            last_index--;
        }
        //nums1=nums1.Concat(nums2).Where(x=>x!=0).OrderBy(x => x).ToArray();
        
        // var tempNum1 = nums1.ToList().Where(x=> x!=0);
        // var tempNum2 = nums2.ToList().Where(x=> x!=0);
        //var result = tempNum1.Concat(tempNum2).OrderBy(x=> x).ToArray();
        //nums1 = result;
    }
}