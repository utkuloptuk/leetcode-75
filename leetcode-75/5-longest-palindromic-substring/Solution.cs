using System.Text;

namespace leetcode_75._5_longest_palindromic_substring;

public class Solution
{
    public static string LongestPalindrome(string s)
    {
        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            int leftPointer = i;
            int rightPointer = i;
            while (leftPointer >= 0 && rightPointer < s.Length && s[leftPointer] == s[rightPointer])
            {
                if (res.Length < rightPointer-leftPointer+1)
                {
                    res=s.Substring(leftPointer, rightPointer-leftPointer+1);
                }
                leftPointer--;
                rightPointer++;
            }
            leftPointer = i;
            rightPointer = i+1;
            while (leftPointer >= 0 && rightPointer < s.Length && s[leftPointer] == s[rightPointer])
            {
                if (res.Length < rightPointer - leftPointer + 1)
                {
                    res = s.Substring(leftPointer, rightPointer - leftPointer + 1);
                }

                leftPointer--;
                rightPointer++;
            }
        }
        return res;
    }
}

