namespace leetcode_75._219_contains_deplicate_2;

public static class Solution
{
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        //On time comp
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (set.Contains(nums[i]))
                return true;
            
            set.Add(nums[i]);
            if (set.Count > k)
                set.Remove(nums[i - k]);
        }

        return false;
        //On2 time complexity
        // for (int i = 0; i < k; i++)
        // {
        //     int first = 0;
        //     int last = first+1+i;
        //     while (last < nums.Length)
        //     {
        //         if (nums[last] == nums[first] && Math.Abs(first - last) <= k)
        //             return true;
        //         last++;
        //         first++;
        //     }
        // }
        // return false;
        //wrong approach
        // int first = 0;
        // int last = first+1;
        // bool checker = false;
        // while (last < nums.Length)
        // {
        //     if (nums[last] == nums[first] && Math.Abs(first - last) <= k)
        //     {
        //         checker = true;
        //         break;
        //     }
        //     else
        //     {
        //         if (Math.Abs(first - last) == k)
        //         {
        //             first++;
        //             last++;
        //         }
        //         else
        //             last++;
        //     }
        // }
        // return checker;
    }
}