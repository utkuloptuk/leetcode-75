namespace leetcode_75._441_arranging_coins;

public static class Solution
{
    public static int ArrangeCoins(int n)
    {
        //binarysearch
        long left = 0;
        long right = n;
        while (left <= right)
        {
            long mid = left + (right - left) / 2;
            if ((mid * (mid + 1)) / 2 <= n)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return (int)right;
        //no efficient way
        // int temp = n;
        // for (int i = 0; i <=n; i++)
        // {
        //     temp = temp - i;
        //     if (temp == 0)
        //         return i;
        //     if(temp<0)
        //         return i-1;
        // }
        //
        // return 0;
    }
}