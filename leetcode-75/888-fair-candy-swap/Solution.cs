namespace leetcode_75._888_fair_candy_swap;

public static class Solution
{
    public static int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
    {
        int aliceSum = aliceSizes.Sum();
        int bobSum = bobSizes.Sum();
        int diff=aliceSum - bobSum;
        HashSet<int> bobs=new HashSet<int>(bobSizes);
        HashSet<int> alice=new HashSet<int>(aliceSizes);
        int aliceSwap = default(int);
        int bobSwap = default(int);
        foreach (var aliceCandy in alice)
        {
            int idealBobBox = aliceCandy - (diff / 2);
            if(bobs.Contains(idealBobBox))
            {
                aliceSwap = aliceCandy;
                bobSwap = idealBobBox;
                break;
            }
            // int regularCandy = aliceCandy - diff / 2;
            // int left = 0;
            // int right = bobs.Count - 1;
            // while (left < right)
            // {
            //     int middle = (left+right) / 2;
            //     if (bobSizes[middle] == regularCandy)
            //     {
            //         aliceSwap=aliceCandy;
            //         bobSwap = bobSizes[middle];
            //     }
            //     if(bobSizes[middle] < regularCandy)
            //         left = middle + 1;
            //     if(bobSizes[middle] > regularCandy)
            //         right = middle - 1;
            // }
        
        }
        return new int[]{aliceSwap, bobSwap};
        //bu çalışmalı idi ancak son test caseinde patlıyor
        // long aliceSizeSum = aliceSizes.Sum();
        // long bobSizeSum = bobSizes.Sum();
        // long sum=(bobSizeSum+aliceSizeSum)/2;
        // long aliseSize=aliceSizes.Length;
        // long bobSize=bobSizes.Length;
        // Array.Sort(bobSizes);
        // for (int i = 0; i < aliseSize; i++)
        // {
        //     long left = 0;
        //     long right = bobSize-1;
        //     int searchingValue = (int)Math.Abs(sum - aliceSizeSum+ aliceSizes[i]);
        //     while (left <= right)
        //     {
        //         long middle = (left + right) / 2;
        //         if (bobSizes[middle] == searchingValue)
        //             return new int[] { aliceSizes[i], bobSizes[middle] };
        //         else
        //         {
        //             if (bobSizes[middle] < searchingValue)
        //                 left = middle + 1;
        //             else
        //                 right = middle - 1;
        //         }
        //     }
        //
        // }
        // return null;
    }
}