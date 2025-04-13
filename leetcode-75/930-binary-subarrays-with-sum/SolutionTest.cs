using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._930_binary_subarrays_with_sum;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1,0,1,0,1 }, 2, 4)]
    [DataRow(new int[] { 0,0,0,0,0}, 0, 15)]
    [DataRow(new int[] { 0,0,0,0,0,0,1,0,0,0}, 0, 27)]
    public void Binary_Search_is_Succeed(int[] numbs, int target, int expected)
    {
        var result = Solution.NumSubarraysWithSum(numbs, target);
        Assert.AreEqual(expected, result);
    }
}