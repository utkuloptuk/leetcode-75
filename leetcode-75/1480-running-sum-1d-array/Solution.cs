
namespace leetcode_75._1480_running_sum_1d_array
{
    public static class Solution
    {
        public static int[] RunningSum(int[] nums)
        {
            int sum = 0;
            List<int> package = new();
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                package.Add(sum);
            }
            return package.ToArray();
        }
    }
}
