using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_75._392_is_subsequence
{
    public static class Solution
    {
        public static bool IsSubsequence(string s, string t)
        {
            if (s == null || string.IsNullOrEmpty(s))
                return true;
            int index = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < t.Length; i++)
            {
                if (s[index] == t[i]&&index<s.Length)
                {
                    sb.Append(t[i].ToString());
                    index++;
                }
                if(index == s.Length)
                    return sb.ToString() == s;
            }
            return sb.ToString() == s;
            // HashSet<char> set = new HashSet<char>();
            // for (int i = 0; i < s.Length; i++)
            // {
            //     set.Add(s[i]);
            // }
            // for (int i = 0; i < t.Length; i++)
            // {
            //     if (set.Contains(t[i]))
            //         set.Remove(t[i]);
            // }
            //
            // return set.Count == 0;
        }
    }
}
