using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._268_missing_number;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[]{3,0,1}, 2)]
    [DataRow(new int[]{9,6,4,2,3,5,7,0,1}, 8)]
    public void sqrt_is_correct(int[] numbs, int expectedResult)
    {
        var result = Solution.MissingNumber(numbs);
        Assert.AreEqual(expectedResult, result);
    }
}