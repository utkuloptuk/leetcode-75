

namespace leetcode_75._153_find_minimum_rotated_sorted_array
{
    public static class Solution
    {
        public static int FindMinValue(int[] sortedArray)
        {
            int left = 0;
            int right = sortedArray.Length - 1;
            int result = sortedArray[0];
            int mid = (left + right) / 2;
            while (left <= right)
            {    
                if (sortedArray[left] < sortedArray[right])
                {
                    result = Math.Min(result, sortedArray[left]);
                    break;
                }
                result = Math.Min(result, sortedArray[mid]);
                if (sortedArray[mid] >= sortedArray[left])
                {
                    left = mid + 1;
                    mid++;
                }
                else
                {
                    right = mid - 1;
                    mid--;
                }
            }
            return result;
        }
    }
}
