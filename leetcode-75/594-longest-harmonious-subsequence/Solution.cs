namespace leetcode_75._594_longest_harmonious_subsequence;

public static class Solution
{
    public static int FindLHS(int[] nums)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int result = 0;
        foreach (var kvp in nums)
        {
            if (map.ContainsKey(kvp))
                map[kvp]++;
            else
                map.Add(kvp, 1);
        }

        foreach (var kvp in map)
        {
            int mockResult = 0;
            int key = kvp.Key;
            if (map.ContainsKey(key + 1))
            {
                mockResult = map[key]+map[key+1];
                result=Math.Max(result, mockResult);
            }
            
        }

        return result;
        //Onlogn time On memory not good enough
        // Dictionary<int, int> map = new Dictionary<int, int>();
        // Array.Sort(nums);
        // int result = 0;
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (!map.ContainsKey(nums[i]))
        //         map.Add(nums[i], 1);
        //     else
        //     {
        //         map[nums[i]] = map[nums[i]] + 1;
        //     }
        // }
        //
        // for (int i = 0; i < nums.Length-1; i++)
        // {
        //     int first = nums[i];
        //     int second = nums[i + 1];
        //     int mockResult = 0;
        //     if (first + 1 == second)
        //     {
        //         mockResult=map[first]+map[second];
        //         result = Math.Max(result, mockResult);
        //     }
        // }
        // return result;
    }


}