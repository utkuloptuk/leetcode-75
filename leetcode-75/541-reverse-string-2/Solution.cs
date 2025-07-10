using System.Text;

namespace leetcode_75._541_reverse_string_2;

public static class Solution
{
    public static string ReverseStr(string s, int k) {
        StringBuilder result=new StringBuilder();
        if (k > s.Length)
        {
            return ReverseSubStr(s);
        }
        for (int i = 0; i < s.Length; i = i + k)
        {
            if ((i / k) % 2 != 0)
                result.Append(s.Substring(i, k <= s.Length - 1 - i ? k:s.Length-i ));
            else
            {
                result.Append(ReverseSubStr(s.Substring(i,k <= s.Length - 1 - i ? k:s.Length-i )));
            }
        }
        return result.ToString();
    }

    private static string ReverseSubStr(string s)
    {
        var length = s.Length;
        char[] result = s.ToCharArray();
        for (int i = 0; i < length / 2; i++)
        {
          (result[i], result[length - i - 1]) = (result[length - i - 1], result[i]);
        }
        return new string(result);

    }
}