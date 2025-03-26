using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._209_minimum_size_subarray;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(7,new int[] { 2,3,1,2,4,3}, 2)]
    [DataRow(4,new int[] { 1,4,4 }, 1)]
    [DataRow(11,new int[] { 1,1,1,1,1,1,1,1}, 0)]
    [DataRow(11,new int[] { 1,2,3,4,5}, 3)]
    [DataRow(7,new int[] { 5}, 0)]
    [DataRow(7,new int[] { 10,2,3}, 1)]
    [DataRow(7,new int[] { 1,1,1,1,7}, 1)]
    public void minimum_size_is_succeed(int target,int[] list, int expectedResult)
    {
        var result = Solution.MinSubArrayLen(target,list);
        Assert.AreEqual(expectedResult, result);

    }
}