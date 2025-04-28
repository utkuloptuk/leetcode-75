namespace leetcode_75._2379_minimum_recolors_to_get_k;

public static class Solution
{
    //On time o1 memory
    public static int MinimumRecolors(string blocks, int k)
    {
        int max = 0;
        int countW = 0;
        int countB = 0;
        for (int i = 0; i < k; i++)
        {
            if(blocks[i] == 'W')
                countW++;
            else
                countB++;
        }
        max = countB;
        for (int i = k; i < blocks.Length; i++)
        {
            if (blocks[i] == 'B')
            {
                countB++;
                if (blocks[i - k] == 'W')
                    countW--;
                else
                    countB--;
            }
            else
            {
             countW++;
             if (blocks[i-k] == 'B')
                 countB--;
             else
                 countW--;
            }
            max = Math.Max(countB,max);
        }

        return k - max;
    }
}