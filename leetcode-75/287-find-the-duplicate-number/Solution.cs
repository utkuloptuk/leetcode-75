namespace leetcode_75._287_find_the_duplicate_number;

public class Solution
{
    public static  int FindDuplicate(int[] nums) {
        //cycle detection or floyd tortoise and hare algoritm.O(n) time and O(1)memory
        int slow=nums[0];
        int fast=nums[0];
        do
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        } while (slow != fast);

        slow = nums[0];
        while (slow != fast)
        {
            slow=nums[slow];
            fast = nums[fast];
        }
        return slow;
        // Array.Sort(nums);
        // int first = 0;
        // int second = 1;
        // var result = nums[0];
        // while (second < nums.Length)
        // {
        //     if (nums[second] != nums[first])
        //     {
        //         first++;
        //         second++;
        //     }
        //     else
        //     {
        //         result = nums[second];
        //         break;
        //     }
        // }
        // return result;
    }
}