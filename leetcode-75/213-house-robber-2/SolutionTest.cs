using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._213_house_robber_2;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void HouseRobber_is_Succeed_Case_1()
    {
        int[] req = new int[] { 2,3,2 };
        int res = 3;
        var result = Solution.HouseRobber2(req);
        Assert.AreEqual(res,result);
    }
    [TestMethod]
    public void HouseRobber_is_Succeed_Case_2()
    {
        int[] req = new int[] { 1,2,3,1};
        int res = 4;
        var result = Solution.HouseRobber2(req);
        Assert.AreEqual(res,result);
    }
    [TestMethod]
    public void HouseRobber_is_Succeed_Case_3()
    {
        int[] req = new int[] { 1,2,3};
        int res = 3;
        var result = Solution.HouseRobber2(req);
        Assert.AreEqual(res,result);
    }

}