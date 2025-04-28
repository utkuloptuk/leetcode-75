using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._2379_minimum_recolors_to_get_k;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow("WBBWWBBWBW",7, 3)]
    [DataRow("WBWBBBW",2,  0)]
    [DataRow("W",1,  1)]
    [DataRow("BWBBWWBBBWBWWWBWWBBWBWBBWBB",11,  4)]
    public void FindPivotIndex_is_Succeed(string chars,int k,int excepted_result)
    {
        var result = Solution.MinimumRecolors(chars,k);
        Assert.AreEqual(result,excepted_result);
    }
}