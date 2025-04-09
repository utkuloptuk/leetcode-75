namespace leetcode_75._1652_defuse_the_bomb;

public static class Solution
{
    public static int[] Decrypt(int[] code, int k)
    {
        List<int> result = new List<int>();
        if (k == 0)
        {
            for (int i = 0; i < code.Length; i++)
            {
                result.Add(0);
            }
        }
        else
        {
            for (int j = 0; j < code.Length; j++)
            {
                int sum = 0;
                if (k > 0)
                {
                    for (int i = 1; i <=k; i++)
                    {
                        sum+=code[(j+i)%code.Length];
                    }
                }
                else
                {
                    for (int i = 1; i <=-k; i++)
                    {
                        sum += code[(j-i+code.Length)%code.Length];
                    }
                }
                result.Add(sum);
            }
        }
        return result.ToArray();
        // else
        // {
        //     int first = code.Length-Math.Abs(k);
        //         for (int i = first; i < first + code.Length; i++)
        //         {
        //             int mockDigit = Math.Abs(k)-1;
        //             int sum = 0;
        //             while (mockDigit >= 0)
        //             {
        //                 sum += code[(i+mockDigit) % (code.Length)];
        //                 mockDigit--;
        //             }
        //             result.Add(sum);
        //         }
        //  
        // }
        // return result.ToArray();
    }
}