using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._202_happy_number;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(19,true)]
    [DataRow(2,false)]
    
    public void best_time_best_sell_max_profit_is_correct(int number,bool expectedResult)
    {
        var result = Solution.HappyNumber(number);
        Assert.AreEqual(expectedResult, result);
    }
}