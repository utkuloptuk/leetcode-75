namespace leetcode_75._198_house_robber;

public static class Solution
{
    public static int HouseRobber(int[] nums)
    {
        int rob1=0;
        int rob2 = 0;
        foreach (int num in nums)
        {
            int temp = num + rob1 > rob2 ? num + rob1 : rob2;
            rob1 = rob2;
            rob2 = temp;
        }
        return rob2;
    }
    
}