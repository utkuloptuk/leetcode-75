using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._1763_longest_nice_substring;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow("YazaAay","aAa")]
    [DataRow("Bb",  "Bb")]
    [DataRow("c",  "")]
    public void FindPivotIndex_is_Succeed(string nums,string exceptedResult)
    {
        var result = Solution.LongestNiceSubstring(nums);
        Assert.IsTrue(result.SequenceEqual(exceptedResult));
    }
}