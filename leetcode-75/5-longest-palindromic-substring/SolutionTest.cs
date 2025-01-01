using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._5_longest_palindromic_substring;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow("aacabdkacaa","aca")]
    [DataRow("babad","bab")]
    [DataRow("cbbd","bb")]
    [DataRow("ac","a")]
    
    public void long_polindrome_substring(string str,string expectedResult)
    {
        var result = Solution.LongestPalindrome(str);
        Assert.AreEqual(expectedResult, result);
    }
}