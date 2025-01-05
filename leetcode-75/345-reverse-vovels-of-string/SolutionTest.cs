using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._345_reverse_vovels_of_string;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow("IceCreAm","AceCreIm")]
    [DataRow("leetcode","leotcede")]
    [DataRow("a.","a.")]
    
    public void reverse_string_succeed(string s,string expectedResult)
    {
        var result =Solution.ReverseVowels(s);
        Assert.AreEqual(expectedResult, result);
    }
}