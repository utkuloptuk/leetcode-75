using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._441_arranging_coins;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(8, 3)]
    [DataRow(5, 2)]
    [DataRow(1, 1)]
    [DataRow(1804289383, 60070)]

public void coin_arrange_is_Succeed(int coin, int expected)
    {
        var result=Solution.ArrangeCoins(coin);
        Assert.AreEqual(expected, result);
    }
}