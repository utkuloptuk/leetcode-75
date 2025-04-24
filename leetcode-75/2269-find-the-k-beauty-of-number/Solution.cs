using System.Text;

namespace leetcode_75._2269_find_the_k_beauty_of_number;

public static class Solution
{
    // O(n) time comp O(1) memory
    public static int DivisorSubstrings(int num, int k)
    {
        string arrayList = num.ToString();
        int counter = 0;
        for (int i = 0; i <= arrayList.Length - k; i++)
        {
            StringBuilder nums = new StringBuilder();
            for (int j = i; j <= i + k-1; j++)
            {
                nums.Append(arrayList[j]);
            }
            int mockDigit = int.Parse(nums.ToString());
            if(mockDigit!=0&&num%mockDigit==0)
                counter++;
        }
        return counter;
    }
}