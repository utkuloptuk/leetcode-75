using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._16_3sum_closest;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    // [DataRow(new int[] { -1,2,1,-4 },  1,2)]
     // [DataRow(new int[] { 0,0,0 }, 1,0)]
    [DataRow(new int[] { 1,1,1,0}, -100,2)]
    public void ThreeSumClosest_is_Succeed(int[] numbs, int target,int excepted_result)
    {
        var result = Solution.ThreeSumClosest(numbs,target);
        Assert.AreEqual(excepted_result, result);

    }
}