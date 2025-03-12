using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._287_find_the_duplicate_number;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[]{1,3,4,2,2}, 2)]
    [DataRow(new int[]{3,1,3,4,2}, 3)]
    [DataRow(new int[]{3,3,3,3,3}, 3)]

    public void find_duplicate_Succeed(int[] coin, int expected)
    {
        var result=Solution.FindDuplicate(coin);
        Assert.AreEqual(expected, result);
    }
}