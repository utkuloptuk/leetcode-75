namespace leetcode_75._2089_find_target_indices;

public static class Solution
{
    public static IList<int> TargetIndices(int[] nums, int target) {
        Array.Sort(nums);
        int first = 0;
        int last=nums.Length-1;
        List<int> indices = new List<int>();
        while (first <= last)
        {
            int mid = (first + last) / 2;
            if (nums[mid] == target)
            {
                indices.Add(mid);
                int left=mid - 1;
                while (left >= 0 && nums[left] == target)
                {
                    indices.Add(left);
                    left--;
                }
                int right = mid + 1;
                while (right < nums.Length && nums[right] == target)
                {
                    indices.Add(right);
                    right++;
                }

                break;
            }

            if (nums[mid] < target)
            {
                first = mid + 1;
            }

            if (nums[mid] > target)
            {
                last = mid - 1;
            }
        }
        indices.Sort();
        return indices;
    }
}