using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._594_longest_harmonious_subsequence;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1,3,2,2,5,2,3,7}, 5)]
    [DataRow(new int[] { 1,2,3,4},  2)]
    [DataRow(new int[] { 1,1,1,1},  0)]
    [DataRow(new int[] { 1,1},  0)]
    public void Binary_Search_is_Succeed(int[] numbs, int expected)
    {
        var result=Solution.FindLHS(numbs);
        Assert.AreEqual(expected, result);
    }
}