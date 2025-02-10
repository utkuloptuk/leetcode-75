using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._35_search_insert_position;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1,3,5,6}, 5,2)]
    [DataRow(new int[] { 1,3,5,6}, 2, 1)]
    [DataRow(new int[] { 1,3,5,6}, 7, 4)]
    public void Binary_Search_is_Succeed(int[] numbs, int target, int expected)
    {
        var result=Solution.SearchInsert(numbs, target);
        Assert.AreEqual(expected, result);
    }
}