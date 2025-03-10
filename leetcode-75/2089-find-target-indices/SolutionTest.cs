using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._2089_find_target_indices;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1,2,5,2,3}, 2,new int[] { 1,2})]
    [DataRow(new int[] { 1,2,5,2,3}, 3,new int[] { 3})]
    [DataRow(new int[] { 1,2,5,2,3}, 5,new int[]{4})]
    [DataRow(new int[] { 100,1,100}, 100,new int[]{1,2})]
    public void FindPivotIndex_is_Succeed(int[] nums,int target, int[] excepted_result)
    {
        var result = Solution.TargetIndices(nums,target);
        Assert.IsTrue(result.SequenceEqual(excepted_result));
    }
}