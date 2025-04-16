using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._1876_substrings_of_size_three_with_distinct_characters;

[TestClass]
public class SolutionTest
{
    [TestMethod]
      [DataRow("xyzzaz", 1)]
    [DataRow("aababcabc",  4)]
    [DataRow("owuxoelszb",  8)]
    public void FindPivotIndex_is_Succeed(string nums,int excepted_result)
    {
        var result = Solution.CountGoodSubstrings(nums);
        Assert.AreEqual(result,excepted_result);
    }
}