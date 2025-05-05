using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._1004_max_consecutive_ones_3;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1,1,1,0,0,0,1,1,1,1,0}, 2,6)]
    [DataRow(new int[] { 0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1 }, 3,10)]

    public void RunnigSum_Method_is_Succeed(int[] numbs,int k, int excepted_result)
    {
        var result=Solution.LongestOnes(numbs,k);
        Assert.AreEqual(excepted_result, result);
    }
}