using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._1385_find_the_distance_value;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 4,5,8},new int[] { 10,9,1,8}, 2,2 )]
     [DataRow(new int[] { 1,4,2,3},new int[] { -4,-3,6,10,20,30}, 3,2 )]
    [DataRow(new int[] { 2,1,100,3},new int[] { -5,-2,10,-3,7}, 6,1 )]
    public void FindPivotIndex_is_Succeed(int[] nums, int[] nums2, int marker,int expected)
    {
        var result = Solution.FindTheDistanceValue(nums, nums2, marker);
        Assert.AreEqual(result,expected);
    }
}