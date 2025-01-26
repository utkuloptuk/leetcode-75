namespace leetcode_75._31_next_permutation;

public static class Solution
{
    public static void NextPermutation(int[] nums)
    {
        int pivot = -1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            if (nums[i] < nums[i + 1])
            {
                pivot = i;
                break;
            }
        }

        if (pivot == -1)
        {
            int firstIndex = pivot + 1;
            int lastIndex = nums.Length - 1;
            while (firstIndex < lastIndex)
            {
                (nums[firstIndex], nums[lastIndex]) = (nums[lastIndex], nums[firstIndex]);
                firstIndex++;
                lastIndex--;
            }
        }
        else
        {
            for (int i =nums.Length-1; i >= pivot; i--)
            {
                if (nums[i] > nums[pivot])
                {
                    (nums[i], nums[pivot]) = (nums[pivot], nums[i]);
                    break;
                }
            }

            int firstIndex = pivot + 1;
            int lastIndex = nums.Length - 1;
            while (firstIndex < lastIndex)
            {
                (nums[firstIndex], nums[lastIndex]) = (nums[lastIndex], nums[firstIndex]);
                firstIndex++;
                lastIndex--;
            }
                
        }
        
        // if (nums.Length == 1)
        // {
        // }
        // if(nums.Length == 2)
        //     (nums[0], nums[1]) = (nums[1], nums[0]);
        // else if(nums.Length >= 3)
        // {
        //     int firstPointer = nums.Length - 2;
        //     int lastPointer = nums.Length - 1;
        //     while (firstPointer!=nums.Length-1)
        //     {
        //
        //         if (nums[firstPointer] < nums[lastPointer])
        //         {
        //             (nums[firstPointer], nums[lastPointer]) = (nums[lastPointer], nums[firstPointer]);
        //             firstPointer=nums.Length-1;
        //         }
        //
        //         if (nums[firstPointer] > nums[lastPointer] && firstPointer == 0&&firstPointer!=nums.Length-1)
        //         {
        //             firstPointer = nums.Length - 1;
        //             lastPointer--;
        //             (nums[firstPointer], nums[lastPointer]) = (nums[lastPointer], nums[firstPointer]);
        //         }
        //
        //         if (firstPointer != nums.Length-1)
        //         {
        //             firstPointer--;
        //             lastPointer--;
        //         }
        //     }
        // }
    }
}