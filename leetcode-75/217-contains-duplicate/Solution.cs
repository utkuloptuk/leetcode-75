using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode_75._217_contains_duplicate
{
    public static class Solution
    {
        public static bool CheckListForDuplicateRecord(int[] list)
        {
            HashSet<int> set = new HashSet<int>();
            for(int i=0; i<list.Length;i++)
            {
                if (set.Contains(list[i]))
                {
                    return true;
                }
                set.Add(list[i]);
            }
            return false;
        }
    }
}
