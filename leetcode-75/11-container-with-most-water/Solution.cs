namespace leetcode_75._11_container_with_most_water;

public static class Solution
{
    public static int MaxArea(int[] height)
    {
        int leftIndex = 0;
        int rightIndex = height.Length - 1;
        int total = 0;
        while (leftIndex <= rightIndex)
        {
            int tempTotal=(rightIndex-leftIndex)*Math.Min(height[leftIndex],height[rightIndex]);
            if(total<tempTotal)
                total=tempTotal;
            
            if(height[leftIndex] > height[rightIndex])
                rightIndex--;
            else
            {
                leftIndex++;
            }
        }
        return total;
        // int leftIndex = 0;
        // int total = 0;
        // for (int i = 0; i < height.Length; i++)
        // {
        //     int tempTotal=Math.Min(height[i], height[leftIndex])*(i-leftIndex);
        //     if (height[i] > height[leftIndex]&i-leftIndex >=Math.Abs(height[i]-height[leftIndex]))
        //     {
        //         leftIndex = i;
        //     }
        //
        //     if (tempTotal > total)
        //     {
        //         total = tempTotal;
        //     }
        // }
        //
        // return total;
    }
}