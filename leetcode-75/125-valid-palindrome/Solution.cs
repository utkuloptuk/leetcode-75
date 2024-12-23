using System.Text.RegularExpressions;

namespace leetcode_75._125_valid_palindrome;

public class Solution
{
    public static bool ValidPalindrome(string s)
    {
        if(s==" ")
            return true;
        string cleanString = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();
        int rIndex = cleanString.Length-1;
        int lIndex = 0;
        for (int i = 0; i < cleanString.Length/2; i++)
        {
            if (cleanString[lIndex] != cleanString[rIndex])
                return false;
            rIndex--;
            lIndex++;
        }
        return true;
    }
}