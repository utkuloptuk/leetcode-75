using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._718_maximum_length_of_repeated_subarray;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1,2,3,2,1},new int[] { 3,2,1,4,7}, 3)]
    [DataRow(new int[] { 0,0,0,0,0},new int[] { 0,0,0,0,0},5)]
    [DataRow(new int[] { 1,2,3,4,5},new int[] { 9,8,7,6,5},1)]
    [DataRow(new int[] { 0,0,0,0,1},new int[] { 1,0,0,0,0},4)]

    public void maxLength_is_Succeed(int[] nums,int[] nums2, int excepted_result)
    {
        var result = Solution.FindLength(nums,nums2);
        Assert.AreEqual(result, excepted_result);
    }
}