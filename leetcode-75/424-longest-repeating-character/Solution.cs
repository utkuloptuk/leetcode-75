namespace leetcode_75._424_longest_repeating_character;

public static class Solution
{
    public static int CharacterReplacement(string s, int k)
    {
        //On time On memory
        Dictionary<char, int> map = new Dictionary<char, int>() ;
        int max = 0;
        int length = 0;
        int left = 0;
        for (int right = 0; right < s.Length; right++)
        {
            if(!map.ContainsKey(s[right]))
                map[s[right]] = 0;
            map[s[right]]++;
            max=Math.Max(max, map[s[right]]);

            if (right - left + 1 - max > k)
            {
                map[s[left]]--;
                left++;
            }
            length=Math.Max(length,right - left + 1);
        }
        return length;
        //wrong approach
        // int first = 0;
        // int second = 0;
        // int diffPointer = 0;
        // int max = 0;
        // int mockK = k;
        // while (second < s.Length)
        // {
        //     if (s[first] == s[second])
        //     {
        //         second++;
        //         max=Math.Max(max,second - first);
        //     }
        //     else
        //     {
        //         if (mockK - 1 >= 0)
        //         {
        //             if (mockK == k)
        //                 diffPointer = second;
        //             mockK--;
        //             second++;
        //             max = Math.Max(max, second - first);
        //         }
        //         else
        //         {
        //             max = Math.Max(max, second - first);
        //             if (k == 0)
        //             {
        //                 diffPointer = second;
        //             }
        //             first = diffPointer;
        //             second = diffPointer;
        //             mockK = k;
        //         }
        //     }
        // }
        //
        // return max;
    }
}