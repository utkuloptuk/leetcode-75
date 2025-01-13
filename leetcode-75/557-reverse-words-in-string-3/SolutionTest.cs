using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._557_reverse_words_in_string_3;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow("Let's take LeetCode contest","s'teL ekat edoCteeL tsetnoc")]
    [DataRow("Mr Ding","rM gniD")]
    public void reverse_string_succeed(string s,string expectedResult)
    {
        var result =Solution.ReverseWords(s);
        Assert.AreEqual(expectedResult, result);
    }
}