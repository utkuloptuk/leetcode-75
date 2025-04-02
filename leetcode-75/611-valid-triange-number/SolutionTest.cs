using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._611_valid_triange_number;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    // [DataRow(new int[] { 2,2,3,4 }, 3)]
    [DataRow(new int[] { 4,2,3,4}, 4)]

    public void FindPivotIndex_is_Succeed(int[] nums, int excepted_result)
    {
        var result = Solution.TriangleNumber(nums);
        Assert.AreEqual(result, excepted_result);
    }
}