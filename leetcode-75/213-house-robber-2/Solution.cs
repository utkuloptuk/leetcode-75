namespace leetcode_75._213_house_robber_2;

public class Solution
{
    public static int HouseRobber2(int[] nums)
    {
        var rob1 = 0;
        var rob2 = 0;
        var result = 0;
        if (nums.Length == 1)
        {
            return nums[0];
        }
        for (var i = 1; i < nums.Length ; i++)
        {
            var temp = nums[i] + rob1 > rob2 ? (nums[i] + rob1) : rob2;
            rob1 = rob2;
            rob2 = temp;
        }

        result = rob2;
        rob1 = 0;
        rob2 = 0;
        for (var i = 0; i < nums.Length - 1; i++)
        {
            var temp = nums[i] + rob1 > rob2 ? (nums[i] + rob1) : rob2;
            rob1 = rob2;
            rob2 = temp;
        }

        result = result > rob2 ? result : rob2;
        return result;
    }

}