namespace leetcode_75._1876_substrings_of_size_three_with_distinct_characters;

public static class Solution
{
    //On time
    public static int CountGoodSubstrings(string s)
    {
        if (s.Length <3)
            return 0;
        int count = 0;
        for (int i = 0; i <= s.Length - 3; i++)
        {
            HashSet<char> set = new HashSet<char>();
            set.Add(s[i]);
            set.Add(s[i + 1]);
            set.Add(s[i + 2]);
            if (set.Count == 3)
                count++;
        }
        return count;
    }
}