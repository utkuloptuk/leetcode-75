using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._643_maximum_average_subarray_1;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1,12,-5,-6,50,3}, 4,12.75000)]
    [DataRow(new int[] { 5}, 1,5.00000)]
    [DataRow(new int[] { -1}, 1,-1.00000)]
    [DataRow(new int[] { 4,0,4,3,3}, 5,2.80000)]
    [DataRow(new int[] { 1,4,2,3,2}, 5,2.40000)]
    public void Binary_Search_is_Succeed(int[] numbs, int target, double expected)
    {
        var result=Solution.FindMaxAverage(numbs, target);
        Assert.AreEqual(expected, result);
    }
}