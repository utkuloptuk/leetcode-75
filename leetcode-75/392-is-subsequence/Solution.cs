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
            var sCharArray = s.ToCharArray().Distinct().ToArray();
            var tChars= t.ToCharArray().Distinct().ToString();
            int firstIndex = 0;
            int SecondIndex = 0;
            for (int i = 0; i < sCharArray.Count(); i++)
            {
                if (t.Contains(sCharArray[i])
                    &&s.Count(x=>x.Equals(sCharArray[i]))<=t.Count(x=>x.Equals(sCharArray[i])))
                {
                    if (i == 0)
                        continue;
                    firstIndex = t.LastIndexOf(sCharArray[i - 1]);
                    SecondIndex = t.LastIndexOf(sCharArray[i]);
                    if (firstIndex > SecondIndex)
                    {
                        return false;
                    }

                }
                else
                    return false;
            }
            return true;
        }
    }
}
