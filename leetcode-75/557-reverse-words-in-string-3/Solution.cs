using System.Text;

namespace leetcode_75._557_reverse_words_in_string_3;

public static class Solution
{
    public static string ReverseWords(string s)
    {
        StringBuilder sb = new StringBuilder();
        string[] words = s.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            int lastPointer = words[i].Length - 1;
            while (lastPointer != -1)
            {
                sb.Append(words[i][lastPointer]);
                lastPointer--;
            }
            if (i<=words.Length-2)
                sb.Append('\u0020');
        }

        return sb.ToString();
    }
}