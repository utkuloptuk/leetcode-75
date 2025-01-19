namespace leetcode_75._350_intersection_of_two_arrays_2;

public static class Solution
{
    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        //chatgpt version daha okunaklı çözüm 2 ile aynı 
        Dictionary<int, int> dict = new Dictionary<int, int>();

        // Count the frequency of each element in nums1
        foreach (int num in nums1)
        {
            if (dict.ContainsKey(num))
                dict[num]++;
            else
                dict[num] = 1;
        }

        List<int> result = new List<int>();

        // Iterate through nums2 and check for matches in the dictionary
        foreach (int num in nums2)
        {
            if (dict.ContainsKey(num) && dict[num] > 0)
            {
                result.Add(num);
                dict[num]--;  // Decrease the count instead of removing and adding
            }
        }

        return result.ToArray();
        //Çozum 2: Time O(n+m) memory O(n+m)
        // Dictionary<int, int> dict = new Dictionary<int, int>();
        // foreach (int num in nums1)
        // {
        //     int count = dict.GetValueOrDefault(num, 0);
        //     dict.Remove(num);
        //     dict.Add(num, count + 1);
        // }
        //
        // List<int> result = new List<int>();
        // foreach (var num in nums2)
        // {
        //     if (dict.ContainsKey(num))
        //     {
        //         int count = dict.GetValueOrDefault(num, 0);
        //         if (count > 0)
        //         {
        //             result.Add(num);
        //             dict.Remove(num);
        //             dict.Add(num, count - 1);
        //         }
        //     }
        // }
        // return result.ToArray();
        
        //Çozum 1 Time O(n*m) memory (n+m)
        // Dictionary<int,int> hs = new Dictionary<int,int>();
        // for (int i = 0; i < nums1.Length; i++)
        //     hs.Add( i, nums1[i]);
        // List<int> result = new List<int>();
        // foreach (int num in nums2)
        // {
        //     if (hs.ContainsValue(num))
        //     {
        //         result.Add(num);
        //         hs.Remove(hs.Where(x=>x.Value == num).First().Key);
        //     }
        // }
        //
        // return result.ToArray();
    }
}