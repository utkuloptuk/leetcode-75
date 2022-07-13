
namespace leetcode_75._724_find_pivot_index
{
    public class Solution
    {
        public static int PivotIndex(int[] nums)
        {

            int result = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                int left = 0;
                int right = 0;
                for (int y = 0; y < i; y++)
                {
                    left += nums[y];
                }
                for (int z = i + 1; z < nums.Length; z++)
                {
                    right += nums[z];
                }
                if (left.Equals(right) && i.Equals(0))
                {
                    result = 0;
                    break;
                }
                else if (left.Equals(right))
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}
