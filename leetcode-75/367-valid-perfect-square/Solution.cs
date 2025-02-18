namespace leetcode_75._367_valid_perfect_square;

public static class Solution
{
    public static bool IsPerfectSquare(int num)
    {
        long first = 0;
        long last = num/2;
        if (num == 1)
            return true;
        while (first <= last)
        {
            long mid = first + (last- first) / 2;
            long square= mid * mid;
            if (num > square)
            {
                first = mid + 1;
            }
            else if (num < square)
            {
                last = mid - 1;
            }
            if(num==square)
                return true;
        }
        return false;
    }
}