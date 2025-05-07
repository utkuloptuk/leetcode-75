using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._1052_grumpy_bookstore_owner;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1,0,1,2,1,1,7,5}, new int[] { 0,1,0,1,0,1,0,1}, 3,16)]
    [DataRow(new int[] { 1}, new int[] { 0},1,1)]
    [DataRow(new int[] { 3}, new int[] { 1},1,3)]
    [DataRow(new int[] { 3,7}, new int[] { 0,0},2,10)]
    [DataRow(new int[] { 8,8}, new int[] { 1,0},2,16)]
    public void Duplicated_Zeros_is_Succeed(int[] numbs, int[] grumpy, int minutes,int expected)
    {
        var result=Solution.MaxSatisfied(numbs,grumpy,minutes);
        Assert.AreEqual(expected, result);
    }
}