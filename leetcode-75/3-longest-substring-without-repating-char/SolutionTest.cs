using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._3_longest_substring_without_repating_char;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow("abcabcbb",3)]
    [DataRow("bbbbb",1)]
    [DataRow("pwwkew",3)]
    [DataRow("a",1)]
    [DataRow("au",2)]
    [DataRow("dvdf",3)]
    
    public void long_polindrome_substring(string str,int expectedResult)
    {
        var result = Solution.LengthOfLongestSubstring(str);
        Assert.AreEqual(expectedResult, result);
    }
}