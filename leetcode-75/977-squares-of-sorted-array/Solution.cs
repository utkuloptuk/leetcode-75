namespace leetcode_75._977_squares_of_sorted_array;

public static class Solution
{
    public static int[] SortedSquares(int[] nums)
    {
        int leftPointer = 0;
        int rightPointer = nums.Length - 1;
        int index = nums.Length - 1;
        int[] result=new int[nums.Length];
        while (leftPointer <= rightPointer)
        {
            int leftSquare=nums[leftPointer]*nums[leftPointer];
            int rightSquare = nums[rightPointer]*nums[rightPointer];

            if (leftSquare > rightSquare)
            {
                result[index] = leftSquare;
                leftPointer++;
            }
            else
            {
                result[index] = rightSquare;
                rightPointer--;
            }

            index--;
        }
        return result;
        //On2 time comp.Not useful.
        // if ( nums.Length == 1)
        // {
        //     return new int[] { nums[0]*nums[0] };
        //     
        // }
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     nums[i] = nums[i]*nums[i];
        // }
        //
        // int firstPointer = 0;
        // int lastPointer = 1;
        // while (firstPointer < nums.Length-1)
        // {
        //     if (firstPointer == lastPointer)
        //     {
        //         lastPointer++;
        //         continue;
        //     }
        //     if (nums[firstPointer] > nums[lastPointer])
        //     {
        //         (nums[firstPointer] , nums[lastPointer])= (nums[lastPointer], nums[firstPointer]);
        //     }
        //     lastPointer++;
        //     if (lastPointer == nums.Length )
        //     {
        //         firstPointer++;
        //         lastPointer = firstPointer+1;
        //     }
        //
        // }
        //
        // return nums;
        //wrong approach
        // Dictionary<int, int> indexing = new Dictionary<int, int>();;
        // int firstPointer = 0;
        // int secondPointer = 1;
        // int index = 0;
        // while (firstPointer < nums.Length)
        // {
        //     if (nums[firstPointer] > nums[secondPointer])
        //         index++;
        //     secondPointer++;
        //     if(firstPointer==secondPointer)
        //         continue;
        //     if (secondPointer == nums.Length)
        //     {
        //         if(!indexing.ContainsKey(index))
        //             indexing.Add(index,nums[firstPointer]);
        //
        //         firstPointer++;
        //         secondPointer=0;
        //         index = 0;
        //     }
        //
        // }
        // int[] result = new int[nums.Length];
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     result[i] = indexing[i];
        // }
        // return result;
    }
}