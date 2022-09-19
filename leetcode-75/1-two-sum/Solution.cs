
namespace leetcode_75._1_two_sum
{
    public static class Solution
    {
        public static int[] TwoSumIndex(int[] nums, int target)
        {
            Dictionary<int, int> maps = new Dictionary<int, int>();
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                maps.Add(i, nums[i]);
                var lists = nums.ToList();
                lists.RemoveAt(i);
                var newArray=lists.ToArray();
                if (newArray.Contains(target - nums[i]))
                {
                    result.Add(i);
                    if (result.Count == 2)
                        break;
                }

            }
            return result.ToArray();
        }
    }
}
