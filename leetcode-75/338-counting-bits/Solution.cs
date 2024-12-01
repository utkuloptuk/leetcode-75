namespace leetcode_75._338_counting_bits;

public class Solution
{
    public static int[] CountBits(int n)
    {
        var bits = Enumerable.Repeat(0, n + 1).ToList();
        var offset = 1;
        for (var i = 1; i < n + 1; i++)
        {
            if (offset * 2 == i)
                offset = i;
            bits[i]=1+bits[i-offset];
        } 
        return bits.ToArray();
    }
}