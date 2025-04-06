namespace leetcode_75._3_longest_substring_without_repating_char;

public static class Solution
{
    public static int LengthOfLongestSubstring(string s)
    {
        HashSet<char> set = new HashSet<char>();
        int result = 0;
        int first = 0;
        int second = 0;
        if(s.Length==0)
            return 0;
        while (second < s.Length)
        {
            if (!set.Contains(s[second]))
            {
                set.Add(s[second]);
                result=Math.Max(result, second-first+1);
                second++;

            }
            else
            {
                set.Remove(s[first]);
                first++;                
            }


        }
        return result;
        //wrong answer
        // HashSet<char> set = new HashSet<char>();
        // int result = 0;
        // int first = 0;
        // while(first < s.Length)
        // {
        //     if (set.Contains(s[first]))
        //     {
        //         result=Math.Max(result,set.Count);
        //         set=new HashSet<char>();
        //     }
        //     else
        //     {
        //         set.Add(s[first]);
        //         if(first==s.Length-1)
        //             result=Math.Max(result,set.Count);
        //         first++;
        //     }
        // }
        // return result;
    }
}