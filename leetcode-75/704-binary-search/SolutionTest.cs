using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._704_binary_search;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { -1,0,3,5,9,12}, 9,4)]
    [DataRow(new int[] { -1,0,3,5,9,12}, 2, -1)]
    [DataRow(new int[] { 2,5}, 5, 1)]
    public void Binary_Search_is_Succeed(int[] numbs, int target, int expected)
    {
        var result=Solution.Search(numbs, target);
        Assert.AreEqual(expected, result);
    }
}