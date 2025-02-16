using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._151_reverse_worlds_in_a_string;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow("the sky is blue", "blue is sky the")]
    [DataRow("  hello world  ", "world hello")]
    public void reverse_string_succeed(string s, string expectedResult)
    {
        var result = Solution.ReverseWords(s);
        Assert.AreEqual(expectedResult, result);
    }
}