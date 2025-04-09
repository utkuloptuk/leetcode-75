using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._1652_defuse_the_bomb;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 5,7,1,4}, 3,new int[] { 12,10,16,13})]
    [DataRow(new int[] { 1,2,3,4}, 0,new int[] { 0,0,0,0})]
    [DataRow(new int[] { 2,4,9,3}, -2,new int[]{12,5,6,13})]
    [DataRow(new int[] { 5,2,2,3,1}, 3,new int[]{7,6,9,8,9})]
    public void FindPivotIndex_is_Succeed(int[] nums,int target, int[] excepted_result)
    {
        var result = Solution.Decrypt(nums,target);
        Assert.IsTrue(result.SequenceEqual(excepted_result));
    }
}