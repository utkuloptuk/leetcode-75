namespace leetcode_75._540_single_element;

public static class Solution
{
    public static int SingleNonDuplicate(int[] nums)
    {
        //Ologn time o1 memory
        int start = 0;
        int end = nums.Length-1;
        if(nums.Length == 1)
            return nums[0];
        if(nums[0]!=nums[1])
            return nums[0];
        if(nums[end]!=nums[end-1])
            return nums[end];
        while (start <= end)
        {
            int mid = (end + start) / 2;
            if(nums[mid] != nums[mid-1]&& nums[mid] != nums[mid+1])
                return nums[mid];
            if(mid%2==0&&nums[mid]==nums[mid-1]||mid%2==1&&nums[mid]==nums[mid+1])
                end = mid - 1;
            else
                start = mid + 1;
        }

        return 0;
        //On time o1 memory complexity.
        // if (nums.Length == 1)
        //     return nums[0];
        // for (int i = 0; i < nums.Length; i=i+2)
        // {
        //     if (i != 0 && i != nums.Length - 1)
        //     {
        //         if(nums[i] != nums[i+1]&& nums[i] != nums[i-1])
        //             return nums[i];
        //     }
        //
        //     if (i == 0&& nums[i] != nums[i+1])
        //         return nums[i];
        //     if(i==nums.Length-1 && nums[i] != nums[i-1])
        //         return nums[i];
        // }
        //
        // return 0;
    }
}