namespace leetcode_75._1763_longest_nice_substring;

public static class Solution
{
    public static string LongestNiceSubstring(string s)
    {
        // On3 time, On space
        int maxlen = 0;
        string result = "";
        int length = s.Length;
        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j <= length; j++)
            {
                string substring = s.Substring(i, j - i);
                if (isNiceSubstring(substring))
                {
                    if (maxlen < substring.Length)
                    {
                        maxlen = substring.Length;
                        result = substring;
                    }
                }
            }
        }

        return result;
    }

    public static bool isNiceSubstring(string s)
    {
        var lower = new bool[26];
        var upper = new bool[26];
        foreach (var c in s)
        {
            if (char.IsLower(c)) lower[c - 'a'] = true;
            else if (char.IsUpper(c)) upper[c - 'A'] = true;
        }

        for (int i = 0; i < 26; i++)
        {
            if (lower[i] != upper[i]) return false;
        }

        return true;
    }
}