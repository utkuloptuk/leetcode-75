using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._540_single_element;
[TestClass]
public class SolutionTest
{
    [TestMethod]
     [DataRow(new int[] {1,1,2,3,3,4,4,8,8},2)]
    [DataRow(new int[] {3,3,7,7,10,11,11},10)]
    [DataRow(new int[] {1,1,2},2)]
    
    public void best_time_best_sell_max_profit_is_correct(int[] number,int expectedResult)
    {
        var result = Solution.SingleNonDuplicate(number);
        Assert.AreEqual(expectedResult, result);
    }
}
