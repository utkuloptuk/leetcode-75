using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._367_valid_perfect_square;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(16, true)]
    [DataRow(14, false)]
    [DataRow(2147483647, false)]
    public void perfect_square_is_correct(int numb, bool expectedResult)
    {
        var result = Solution.IsPerfectSquare(numb);
        Assert.AreEqual(result, expectedResult);
    }
}