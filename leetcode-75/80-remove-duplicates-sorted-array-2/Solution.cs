namespace leetcode_75._80_remove_duplicates_sorted_array_2;

public static class Solution
{
    public static int RemoveDuplicates(int[] nums)
    {
        //Time complexity O(n) memory O(n)
        int sayac = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        foreach(int num in nums)
        {
            if(!dict.TryAdd(num, 1))
                dict[num] += 1;
        }

        foreach (int key in dict.Keys)
        {
            if (dict[key] >= 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    nums[sayac] = key;
                    sayac++;
                }
            }
            else
            {
                nums[sayac] = key;
                sayac++;
            }
        }
        return sayac;
    }
    
}