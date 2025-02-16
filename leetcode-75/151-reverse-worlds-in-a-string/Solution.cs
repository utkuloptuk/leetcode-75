using System.Text;

namespace leetcode_75._151_reverse_worlds_in_a_string;

public static class Solution
{
    public static string ReverseWords(string s)
    {
        List<string> words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
        Dictionary<int, string> dict = new Dictionary<int, string>();
        for (int i = 0; i < words.Count; i++)
        {
            dict.Add(i, words[i]);
        }
        StringBuilder builder = new StringBuilder();
        for (int i = words.Count - 1; i >= 0; i--)
        {
            builder.Append(words[i]);
            if(i!=0)
                builder.Append(" ");
        }
        return builder.ToString();
    }
}