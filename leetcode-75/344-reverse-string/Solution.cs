namespace leetcode_75._344_reverse_string;

public static class Solution
{
    public static void ReverseString(char[] s) {

        for (int i = 0; i < s.Length / 2; i++)
        {
            char temp = s[i];
            s[i] = s[s.Length - 1 - i];
            s[s.Length - 1 - i] = temp;
        }
    }
}