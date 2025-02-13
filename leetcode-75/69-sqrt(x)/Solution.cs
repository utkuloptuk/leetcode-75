namespace leetcode_75._69_sqrt_x_;

public static class Solution
{
    public static int MySqrt(int x)
    {
        // if (x == 0)
        //     return 0;
        //
        // int left = 1;
        // int right = x;
        //
        // while (left <= right) {
        //     int mid = left + (right - left) / 2;
        //     int sqrt = x / mid;
        //
        //     if (sqrt == mid)
        //         return mid;
        //     else if (sqrt < mid)
        //         right = mid - 1;
        //     else
        //         left = mid + 1;
        // }
        //
        // return right;      
        // for (int i = 0; i <= x; i++)
        // {
        //     if ((long)(i * i )> (long)x)
        //         return i - 1;
        // }
        // return x;
        if (x == 0 || x == 1)
            return x;
        
        int first = 0;
        int last = x;
        
        while (first <= last)
        {
            int mid = first + (last - first) / 2;
            long sqrt=(long)mid * mid;
            if (sqrt == x)
                return mid;
        
            else if (sqrt < x)
            {
                first = mid + 1;
            }
            else
            {
                last = mid - 1;
            }
        }
        
        return last; 

    }
}