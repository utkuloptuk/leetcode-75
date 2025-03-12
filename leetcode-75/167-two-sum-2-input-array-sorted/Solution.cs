namespace leetcode_75._167_two_sum_2_input_array_sorted;

public class Solution
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        //O(n) time O(1) memory
        int first = 0;
        int last=numbers.Length-1;
        
        while (first < last)
        {
            if(numbers[first] + numbers[last] == target)
                return new int[] { first+1, last+1 } ;
            if (numbers[first] + numbers[last] > target)
                last--;
            if(numbers[first] + numbers[last] < target)
                first++;
        }
        return new int[] { first, last };
        // for (int i = 0; i <numbers.Length; i++)
        // {
        //     int first = i + 1;
        //     int second = numbers.Length - 1;
        //     int secFirst = first;
        //     int searchNumber=target-numbers[i];
        //     do
        //     {
        //
        //         int mid=(secFirst + second)/2;
        //         if(numbers[mid] == searchNumber)
        //             return new int[] { first, mid+1 };
        //         if(numbers[mid] < searchNumber)
        //             secFirst = mid + 1;
        //         if(numbers[mid] > searchNumber)
        //             second = mid - 1;
        //     }
        //     while (second < numbers.Length ) ;
        // }
        // return new int[] { 0,1};
    }
}