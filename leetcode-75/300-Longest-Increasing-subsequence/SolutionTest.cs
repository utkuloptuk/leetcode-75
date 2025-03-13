using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._300_Longest_Increasing_subsequence;
[TestClass]
public class SolutionTest
{
    [TestMethod]
     [DataRow(new int[]{10,9,2,5,3,7,101,18}, 4)]
    [DataRow(new int[]{0,1,0,3,2,3}, 4)]
    [DataRow(new int[]{7,7,7,7,7,7,7}, 1)]
    [DataRow(new int[]{4,10,4,3,8,9}, 3)]
    [DataRow(new int[]{1,3,6,7,9,4,10,5,6}, 6)]
    public void perfect_square_is_correct(int[] numb, int expectedResult)
    {
        var result = Solution.LengthOfLIS(numb);
        Assert.AreEqual(result, expectedResult);
    }
}