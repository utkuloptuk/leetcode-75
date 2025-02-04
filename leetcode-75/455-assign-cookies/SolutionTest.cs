using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._455_assign_cookies;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 1 },1)]
    [DataRow(new int[] { 1,2 }, new int[] { 1,2,3},2)]
    public void RunnigSum_Method_is_Succeed(int[] child, int[] cookies, int expected)
    {
        var result=Solution.FindContentChildren(child, cookies);
        Assert.AreEqual(expected, result);
    }
}