using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._125_valid_palindrome;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow("A man, a plan, a canal: Panama",true)]
    [DataRow("race a car",false)]
    [DataRow(" ",true)]
    [DataRow("0P",false)]
    public void best_time_best_sell_max_profit_is_correct(string s,bool expectedResult)
    {
        var result = Solution.ValidPalindrome(s);
        Assert.AreEqual(expectedResult, result);
    }
}