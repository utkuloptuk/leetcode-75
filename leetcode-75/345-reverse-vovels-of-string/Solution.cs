using System.Text;

namespace leetcode_75._345_reverse_vovels_of_string;

public static class Solution
{
    public static string ReverseVowels(string s)
    {
        int firstPointer = 0;
        int lastPointer = s.Length - 1;
        StringBuilder sb = new StringBuilder();
        sb.Append(s);
        while (firstPointer < lastPointer)
        {
            if (checkVowels(sb[lastPointer]) && checkVowels(sb[firstPointer]))
            {
                (sb[firstPointer], sb[lastPointer]) = (sb[lastPointer], sb[firstPointer]);
                firstPointer++;
                lastPointer--;
            }
            if(!checkVowels(sb[firstPointer]))
                firstPointer++;
            if(!checkVowels(sb[lastPointer]))
                lastPointer--;
        }
        return sb.ToString();
    }

    public static bool checkVowels(char c)
    {
        string vowel = c.ToString().ToLower();
        if(vowel == "a"|| vowel=="e"|| vowel=="u"|| vowel=="i" || vowel=="o" )
            return true;
        return false;
    }
}