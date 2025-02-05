namespace leetcode_75._42_Trapping_Rain_Water;

public static class Solution
{
    public static int Trap(int[] height)
    {
        int leftPointer = 0;
        int rightPointer =height.Length - 1;
        int maxLeft=height[leftPointer];
        int maxRight=height[rightPointer];
        int result = 0;
        while (rightPointer != leftPointer)
        {
            if (maxLeft > maxRight)
            {
                rightPointer = rightPointer - 1;
                if(maxRight>=height[rightPointer])
                  result += maxRight-height[rightPointer];
                else
                    maxRight=height[rightPointer];
            }

            else
            {
                leftPointer = leftPointer + 1;
                if(maxLeft>=height[leftPointer])
                    result += maxLeft-height[leftPointer];
                else
                {
                    maxLeft=height[leftPointer];
                }
            }
        }
        return result;
        // int first = 0;
        // int last = 1;
        // int tempLast = 0;
        // int tempObject = 0;
        // int result = 0;
        // for (var i = 0; i < height.Length-1; i++)
        // {
        //
        //
        //     tempObject += height[tempLast];
        //     if (height[first] <= height[last] && height[tempLast] < height[last])
        //     {
        //         result+=(last-first)*Math.Min(height[last], height[first])-tempObject;
        //         tempLast = last;
        //         first = last;
        //         last++;
        //         tempObject = 0;
        //     }
        //     else
        //     {
        //         tempLast = last;
        //         last++;
        //     }
        // }
        // return result;
    }
}