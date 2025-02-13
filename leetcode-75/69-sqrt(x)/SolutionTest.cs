using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._69_sqrt_x_;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(4, 2)]
    [DataRow(8, 2)]
    [DataRow(2147395600, 46340)]
    public void sqrt_is_correct(int number, int expectedResult)
    {
        var result = Solution.MySqrt(number);
        Assert.AreEqual(expectedResult, result);
    }
}