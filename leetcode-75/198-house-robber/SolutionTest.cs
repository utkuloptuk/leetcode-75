using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._198_house_robber;

[TestClass]
public class SolutionTest
{
    public void HouseRobber_is_Succeed_Case_1()
    {
        int[] req = new int[] { 1, 2, 3, 1 };
        int res = 4;
        var result = Solution.HouseRobber(req);
        Assert.AreEqual(res,result);
    }
    public void HouseRobber_is_Succeed_Case_2()
    {
        int[] req = new int[] { 2,7,9,3,1};
        int res = 12;
        var result = Solution.HouseRobber(req);
        Assert.AreEqual(res,result);
    }
    
}