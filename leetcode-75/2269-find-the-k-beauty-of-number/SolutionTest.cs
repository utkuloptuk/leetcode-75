using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._2269_find_the_k_beauty_of_number;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(240,2, 2)]
    [DataRow(430043,2,  2)]
    public void FindPivotIndex_is_Succeed(int nums,int k,int excepted_result)
    {
        var result = Solution.DivisorSubstrings(nums,k);
        Assert.AreEqual(result,excepted_result);
    }
}