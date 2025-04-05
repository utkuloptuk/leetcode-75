using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._713_subarray_product_less_than_k;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 10, 5, 2, 6 }, 100, 8)]
    [DataRow(new int[] { 1,2,3 }, 0, 0)]
    public void Binary_Search_is_Succeed(int[] numbs, int target, int expected)
    {
        var result = Solution.NumSubarrayProductLessThanK(numbs, target);
        Assert.AreEqual(expected, result);
    }
}